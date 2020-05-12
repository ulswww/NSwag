using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    /// <summary>
    ///  result_ = Newtonsoft.Json.JsonConvert.DeserializeObject
    ///  result_ = Shambhala.MerchantOfflineServer.Tool.Adapters.AbpJson.ToJson
    /// </summary>
    public class AbpJson
    {
        public static T ToJson<T>(string responseStr, JsonSerializerSettings settings)
        {
            var r = Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResponse<T>>(responseStr, settings);

            if (r.Success)
                return r.Result;
            else
            {
                throw new Exception(r.Error.Message);
            }
        }


        public static T ToJson<T>(JsonTextReader responseStr, JsonSerializerSettings settings)
        {
            var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);
            var r = serializer.Deserialize<AjaxResponse<T>>(responseStr);

            if (r.Success)
                return r.Result;
            else
            {
                throw new Exception(r.Error.Message);
            }

        }
    }
}
