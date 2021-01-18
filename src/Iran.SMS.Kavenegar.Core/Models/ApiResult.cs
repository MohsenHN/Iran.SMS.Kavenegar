﻿using Newtonsoft.Json;

namespace Iran.SMS.Kavenegar.Core.Models
{
    public class ApiResult<T> 
    {
        [JsonProperty("return")]
        public ApiReturnResult Result { get; set; }
        
        [JsonProperty("entries")]
        public T Entries { get; set; }
    }

    public class ApiReturnResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}