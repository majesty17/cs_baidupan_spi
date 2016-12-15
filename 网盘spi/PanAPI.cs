using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace 网盘spi
{
    class PanAPI
    {
        //获取html内容
        public static String htmlGet(String url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 20000;

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();

            httpWebResponse.Close();
            streamReader.Close();

            return responseContent;
        }



        //获取某用户订阅过的人
        public static String[] getfollowlist(String uk,int start,int limit)
        {
            //http://yun.baidu.com/pcloud/friend/getfollowlist?query_uk=1881641340&limit=24&start=0
            String jsontext = htmlGet("http://yun.baidu.com/pcloud/friend/getfollowlist?query_uk=" + uk + "&limit=" + limit + "&start=" + start);
            if (jsontext == null)
                return null;
            Newtonsoft.Json.Linq.JObject json = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(jsontext);
            if (json == null)
                return null;
           

            Newtonsoft.Json.Linq.JArray jarr=(Newtonsoft.Json.Linq.JArray)json["follow_list"];

            if(jarr==null || jarr.Count==0)
                return null;
            String[] ret = new String[jarr.Count];
            for (int i = 0; i < jarr.Count; i++)
                ret[i] = jarr[i]["follow_uk"].ToString();
            return ret;
        }
        //获取某用户订阅过的人数
        public static int getFollowCount(String uk)
        {
            String jsontext = htmlGet("http://yun.baidu.com/pcloud/friend/getfollowlist?query_uk=" + uk + "&limit=1&start=0");
            if (jsontext == null)
                return 0;
            Newtonsoft.Json.Linq.JObject json = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(jsontext);
            if (json == null)
                return 0;

            String count_str=json["total_count"].ToString();
            int count_int = Convert.ToInt32(count_str);
            return count_int;
        }


        //获取某用户的粉丝
        public static String[] getFans(String uk, int start, int limit)
        {
            //http://pan.baidu.com/pcloud/friend/getfanslist?query_uk=1881641340&limit=24&start=24
            String jsontext = htmlGet("http://pan.baidu.com/pcloud/friend/getfanslist?query_uk=" + uk + "&limit=" + limit + "&start=" + start);
            if (jsontext == null)
                return null;
            Newtonsoft.Json.Linq.JObject json = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(jsontext);
            if (json == null)
                return null;

            Newtonsoft.Json.Linq.JArray jarr = (Newtonsoft.Json.Linq.JArray)json["follow_list"];

            if (jarr == null || jarr.Count == 0)
                return null;
            String[] ret = new String[jarr.Count];
            for (int i = 0; i < jarr.Count; i++)
                ret[i] = jarr[i]["follow_uk"].ToString();
            return ret;
        }

        //获取某用户的粉丝数
        public static int getFansCount(String uk)
        {
            return 0;
        }



    }
}
