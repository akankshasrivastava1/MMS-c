using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Model
{
    public class DAL
    {
        DbConnect con;
        public DAL(DbConnect con)
        {
            this.con = con;
        }
        public List<Movie> display()
        {
            List<Movie> ls = con.Movies.ToList();
            return ls;
        }
        public int Search(string s,int d)
        {
            int id1;
            Movie obj = con.Movies.Find(d);
            if (obj.leadactor == s)
            {
                id1 = obj.id;
            }
            
            else if(obj.title==s)
            {
                id1 = obj.id;
            }
            else
            {
                id1 = 0;
            }
        
            return id1;
        }
        public Movie Search1(string name)
        {
            Movie obj = con.Movies.Find(name);
            return obj;
        }
        public Movie Search2(string mname)
        {
            Movie obj = con.Movies.Find(mname);
            return obj;
        }

    }
}
