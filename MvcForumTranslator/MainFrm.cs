using MvcForumTranslator.Modules;
using MvcForumTranslator.PubClass.Http;
using MvcForumTranslator.PubClass.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcForumTranslator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        

        private EFHelper efHelper = new EFHelper();

        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        

        private void btnMacth_Click(object sender, EventArgs e)
        {

            try
            {
                var lanEn = efHelper.context.Languages.Where(m => m.LanguageCulture == "en-GB").FirstOrDefault();
                if (lanEn != null)
                {
                    var lanEnRes = efHelper.context.LocaleStringResources
                        .Where(m => m.Language_Id == lanEn.Id)
                        .Include(m => m.LocaleResourceKey).ToList();

                    foreach (var item in lanEnRes)
                    {
                        dictionary.Add(item.LocaleResourceKey.Name, item.ResourceValue);
                    }
                }

                this.efHelper.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
                MessageBox.Show("载入XML失败!");
                return;
            }
            this.listViewOK.Items.Clear();
            this.listViewNo.Items.Clear();
            this.InitPp(this.listViewOK, this.listViewNo);
        }

        private void InitPp(ListView list1, ListView list2)
        {
            this.efHelper.TextsOK.Clear();
            this.efHelper.TextsNo.Clear();
            this.efHelper.TextsOK = this.efHelper.Texts.Where(m => !string.IsNullOrWhiteSpace(m.ResourceValue)).ToList();
            this.efHelper.TextsNo = this.efHelper.Texts.Where(m => string.IsNullOrWhiteSpace(m.ResourceValue)).ToList();

            foreach (LocaleStringResource textClass3 in this.efHelper.TextsOK)
            {
                ListViewItem listViewItem = list1.Items.Add(textClass3.Id.ToString());
                listViewItem.SubItems.Add(textClass3.LocaleResourceKey.Name);
                listViewItem.SubItems.Add(textClass3.ResourceValue);
            }
            foreach (LocaleStringResource textClass4 in this.efHelper.TextsNo)
            {
                ListViewItem listViewItem2 = list2.Items.Add(textClass4.Id.ToString());
                listViewItem2.SubItems.Add(textClass4.LocaleResourceKey.Name);
                listViewItem2.SubItems.Add("");
            }
        }

        private void listViewOK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtFormer.Text = this.listViewOK.SelectedItems[0].SubItems[1].Text;
                this.txtSearch.Text = this.ToSp(this.listViewOK.SelectedItems[0].SubItems[1].Text);
                this.txtResult.Text = this.listViewOK.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
        }

        private void listViewNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtFormer.Text = this.listViewNo.SelectedItems[0].SubItems[1].Text;
                this.txtSearch.Text = this.ToSp(this.listViewNo.SelectedItems[0].SubItems[1].Text);
                this.txtResult.Text = "";
                this.btnSearch.PerformClick();
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
        }

        private string ToSp(string t)
        {
            string value = string.Empty;
            dictionary.TryGetValue(t, out value);
            return value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;
            this.txtResult.Text = HttpHelper.GetEntoCn(this.txtSearch.Text.Trim()).Replace(" ", "");
            this.btnSearch.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.btnConfirm.Enabled = false;
            string yEn = this.txtFormer.Text;
            string text = this.txtResult.Text;
            LocaleStringResource LocaleStringResource = (from x in this.efHelper.TextsOK
                                                         where x.LocaleResourceKey.Name == yEn
                                                         select x).FirstOrDefault<LocaleStringResource>();
            bool flag = LocaleStringResource != null;
            if (flag)
            {
                LocaleStringResource.ResourceValue = text;
                this.listViewOK.Items[LocaleStringResource.Id.ToString()].SubItems[2].Text = LocaleStringResource.ResourceValue;
            }
            else
            {
                LocaleStringResource = (from x in this.efHelper.TextsNo
                                        where x.LocaleResourceKey.Name == yEn
                                        select x).FirstOrDefault<LocaleStringResource>();
                bool flag2 = LocaleStringResource != null;
                if (flag2)
                {
                    this.efHelper.TextsNo.Remove(LocaleStringResource);
                    this.listViewNo.Items.Remove(this.listViewNo.SelectedItems[0]);
                    LocaleStringResource.ResourceValue = text;
                    this.efHelper.TextsOK.Add(LocaleStringResource);
                }
                ListViewItem listViewItem = this.listViewOK.Items.Add(LocaleStringResource.Id.ToString());
                listViewItem.SubItems.Add(LocaleStringResource.LocaleResourceKey.Name);
                listViewItem.SubItems.Add(LocaleStringResource.ResourceValue);

            }
            try
            {
                bool flag3 = this.listViewNo.Items.Count - 1 > this.listViewNo.SelectedItems[0].Index;
                if (flag3)
                {
                    this.listViewNo.Items[this.listViewNo.SelectedItems[0].Index].Selected = true;
                    this.listViewNo.Items[this.listViewNo.SelectedItems[0].Index].EnsureVisible();
                }
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
            this.btnConfirm.Enabled = true;
            this.listViewNo.Items[0].Selected = true;
        }

        private void ShowList()
        {
            this.listViewOK.Items.Clear();
            this.listViewNo.Items.Clear();
            foreach (LocaleStringResource LocaleStringResource in this.efHelper.TextsOK)
            {
                ListViewItem listViewItem = this.listViewOK.Items.Add(LocaleStringResource.Id.ToString());
                listViewItem.SubItems.Add(LocaleStringResource.LocaleResourceKey.Name);
                listViewItem.SubItems.Add(LocaleStringResource.ResourceValue);
            }
            foreach (LocaleStringResource textClass2 in this.efHelper.TextsNo)
            {
                ListViewItem listViewItem2 = this.listViewNo.Items.Add(textClass2.Id.ToString());
                listViewItem2.SubItems.Add(textClass2.LocaleResourceKey.Name);
                listViewItem2.SubItems.Add("");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.efHelper.Write();
            MessageBox.Show("OK");
        }

    }
}
