using MvcForumTranslator.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MvcForumTranslator.PubClass.EF
{
    public class EFHelper
    {
        public TransContext context = new TransContext();
        public void Write()
        {

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Load()
        {

            var LanZh = context.Languages.Where(m => m.LanguageCulture == "zh-CN").FirstOrDefault();
            if (LanZh != null)
            {
                Texts = context.LocaleStringResources
                    .Where(m => m.Language_Id == LanZh.Id)
                    .Include(m => m.LocaleResourceKey).ToList();
            }
        }

        public List<LocaleStringResource> Texts = new List<LocaleStringResource>();

        public List<LocaleStringResource> TextsOK = new List<LocaleStringResource>();


        public List<LocaleStringResource> TextsNo = new List<LocaleStringResource>();
    }
}
