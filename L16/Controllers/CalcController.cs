using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace wyklad6_moj.Controllers
{
    public class CalcController : ApiController
    {
        // not
        // and
        // or
        // xor
        // shl
        // shr

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

        // GET: api/Calc
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calc/5
        public string Get(int id)
        {
            return "value";
        }

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
