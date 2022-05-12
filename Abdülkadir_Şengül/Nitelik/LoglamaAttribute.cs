using Abdülkadir_Şengül.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Abdülkadir_Şengül.Nitelik
{
    public class LoglamaAttribute : ActionFilterAttribute
    {
        MakaleEntities contact = new MakaleEntities();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Abdülkadir_Şengül.Models.Log yeniLog = new Models.Log();

            yeniLog.Tarih = DateTime.Now;
            yeniLog.IP = filterContext.HttpContext.Request.UserHostAddress;
            yeniLog.Metot = filterContext.ActionDescriptor.ActionName;

            yeniLog.Tarayici = filterContext.HttpContext.Request.Browser.Browser;
            if (filterContext.ActionParameters.Count > 0)
            {
                JavaScriptSerializer serilestir = new JavaScriptSerializer();
                yeniLog.Parametre = serilestir.Serialize(filterContext.ActionParameters);
            }
            contact.Log.Add(yeniLog);
            contact.SaveChanges();
        }
    }

}