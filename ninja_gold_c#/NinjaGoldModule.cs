using Nancy;
using System;
namespace NinjaGold
{
    public class NinjaGoldModule : NancyModule
    {
        public NinjaGoldModule()
        {
            Get ("/", args =>
            { //
                string value;
                int goldTotal = 0; 
                num = goldTotal;
                Session["goldNumber"] = num;
                ViewBag.mySession = num;
                ViewBag.textActivities = Session["textActivities"];
            return View["NinjaGold"];
            });

            Post ("/process_money", args => 
            {
                string value;
                string textWrong;
                string buildingType = Request.Form.building;

                if(buildingType == "Farm"){
                    textWrong = $"You just farmed {goldValue} gold!";
                    goldValue = new Random().Next(10,21);
                    Session["textActivties"] = textWrong;
                    Session["goldNumber"] += goldValue;
                }
                if(buildingType == "Cave"){
                    textWrong = $"You just farmed {goldValue} gold!";
                    goldValue = new Random().Next(5,10);
                    Session["textActivties"] = textWrong;
                    Session["goldNumber"] += goldValue;
                }
                if(buildingType == "House"){
                    textWrong = $"You just farmed {goldValue} gold!";
                    goldValue = new Random().Next(2,5);
                    Session["textActivties"] = textWrong;
                    Session["goldNumber"] += goldValue;
                }
                if( buildingType == "Casino"){
                    textWrong = $"You just farmed {goldValue} gold!";
                    goldValue = new Random().Next(-50,50);
                    textWrong = "You just casinoed goldValue gold!";
                    Session["textActivties"] = textWrong;
                    Session["goldNumber"] += goldValue;
                }
                return Response.AsRedirect("/");
            });
        } 
    }
    
}