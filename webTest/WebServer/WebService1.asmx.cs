using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.52uyou.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public enum TemperatureType
        {
            Fahrenheit,
            Celsius
        }

        public class GetWeatherRequest
        {
            public string City { get;set;}
            public TemperatureType TemperatureType {get;set;}
        }

        public enum TemperatureCondition
        {
            Rainy,
            Sunny,
            Cloudy,
            Thunderstorm
        }

        public class GetWeatherRespose
        {
            public TemperatureCondition Condition { get;set;}
            public int Temperature { get;set;}
        }
        [WebMethod]
        public GetWeatherRespose GetWeather(GetWeatherRequest req)
        {
            var resp = new GetWeatherRespose();
            var r    = new Random();

            int celsius = r.Next(-20, 50);

            if(req.TemperatureType == TemperatureType.Celsius)
            resp.Temperature = celsius;
            else
            resp.Temperature = (212-32)/100*celsius+32;

            if(req.City == "Redmond")
            resp.Condition = TemperatureCondition.Rainy;
            else
            resp.Condition = (TemperatureCondition)r.Next(0,3);

            return resp;
        }
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string ReverseString(string message)
        {
            return new string(message.Reverse().ToArray());
        }
    }
}
