using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto
{
    public class JsonResponse<T> 
    {
        public bool success { get; set; }

        public string message { get; set; }

        public T data { get; set; }

    }

    public class JsonResponse : JsonResponse<string>
    {

    }
}
