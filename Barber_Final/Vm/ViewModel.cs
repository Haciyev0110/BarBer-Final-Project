using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Barber_Final.Models;

namespace Barber_Final.Vm
{
    public class ViewModel
    {
        public List<MainSlider> mainSlider { get; set; }
       public AboutCenter Aboutus { get;set; }
        public About_details Detalis { get; set; }
        public   List<Working_House>  House { get; set; }
        public Our_Services Servicesss { get; set; }
        public   List<Our_Cartinca>  Cartinca { get; set; }
        public Appoint Apoints { get; set; }
    }
}