using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public class Board
{
    public long Bno { get; set; }
    public string Title { get; set; }
    public string Writer { get; set; }
    public string Content { get; set; }
    public string Regdate { get; set; }
    public int Hit { get; set; }
   
}
