﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiuWaiHuiZhong.UI.Models;
using XiuWaiHuiZhong.Utility;

namespace XiuWaiHuiZhong.UI.Controllers.PC
{
    public class HomeController : PCBaseController
    {
        //
        // GET: /Home/

        public ActionResult IndexPage()
        {
            // 热门商品

            DataTable huodongSimpleInfoTable = null;
            List<HomeIndexPageModelOut> huodongSimpleInfoList = new List<HomeIndexPageModelOut>();
            if (huodongSimpleInfoTable != null && huodongSimpleInfoTable.Rows.Count > 0)
            {
                foreach (DataRow row in huodongSimpleInfoTable.Rows)
                {
                    huodongSimpleInfoList.Add(new HomeIndexPageModelOut()
                    {
                        GoodsID = Converter.TryToInt64(row["GoodsID"]),
                        GoodsName = Converter.TryToString(row["GoodsName"]),
                        LastestCustomer = Converter.TryToString(row["LastestCustomer"]),
                        ShareCount = Converter.TryToInt32(row["ShareCount"]),
                        OrderCount = Converter.TryToInt32(row["OrderCount"]),
                        Progress = Converter.TryToDouble(Converter.GetFloatWithoutPoint(Converter.TryToDouble(row["Progress"]).ToString("F2"))),
                        DailyIncrease = Converter.TryToInt32(row["DailyIncrease"]),
                        Describe = Converter.TryToString(row["Describe"]),
                        HuodongNumber = Converter.TryToInt32(row["HuodongNumber"])
                    });
                }
            }
            ViewBag.HuoDongList = huodongSimpleInfoList;

            // 后台日志
            //List<Model.BackgroundUserInfo_log> logList = BLL.BackgroundUserBll_log.GetTop10Logs();
            //ViewBag.LogList = logList;

            // 客户列表
            //List<Model.ConsumerInfo> consumerList = BLL.ConsumerInfoBll.GetTop10ConsumerInfos();
            ViewBag.ConsumerList = null; ;

            return View();
        }

    }
}
