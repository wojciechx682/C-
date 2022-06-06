using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace wyklad6_moj.Controllers
{

    //private static readonly HttpClient client = new HttpClient();


    public class CalcController : ApiController
    {
        // not
        // and
        // or
        // xor
        // shl
        // shr

        int ls;
        string op;
        int rs;

        //http://localhost:59987/api/calc/count?op=not&rs=1

        [HttpGet]
        //Operacja bitowe NOT, AND, XOR...
        public int Count(string op, int rs)
        {            
            if (op == "not")
            {
                //res=~rs;
                return ~rs;
            }
            else if (op == "and")
            {
                rs &= rs;
                //res=~rs;
                return rs;
            }
            else if (op == "or")
            {
                rs |= rs;
                //res=~rs;
                return rs;
            }
            else if (op == "xor")
            {
                rs ^= rs;
                //res=~rs;
                return rs;
            }
            else if (op == "shl")
            {
                rs <<= rs;
                //res=~rs;
                return rs;
            }
            else if (op == "shr")
            {
                rs >>= rs;
                //res=~rs;
                return rs;
            }
            return 0;

            //użycia if, switch, lub case

            // zrobić dwuargumentowy kalkulator

            // lub 1-argumentowy (operacja np. not	
        }
        [HttpGet]
        public int Count(int ls, string op, int rs)
        {
            //http://localhost:59987/api/calc/count?ls=3&op=add&rs=4

            if (op=="add")
            {
                return ls+rs;
            }
            else if (op == "sub")
            {
                return ls-rs;
            }
            else if (op == "mul")
            {
                return ls*rs;
            }
            else if (op == "div")
            {
                return ls/rs;
            }
            return 0;
        }

        [HttpGet]
        public int Home(int ls)
        {
            //http://localhost:59987/api/calc/count?ls=3&op=add&rs=4

            return ls;
            
        }


        [HttpGet]
        public int Asd(int id)
        {
            return id;
        }

        // GET: api/Calc
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calc/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public int Wyslij(int id)
        {
            return id;
        }


        /*[HttpPost]
        public int PostMethod([FromBody]NaszeapiController obj)
        {​​​​​
            var obj = new NazwaKlasy();

            obj.ls = 1;

            obj.op = "+";

            obj.rs = 3;

            return obj.ls obj.op obj.rs;
        }​​​​​*/


        // POST: api/Calc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Calc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Calc/5
        public void Delete(int id)
        {
        }
    }
}
