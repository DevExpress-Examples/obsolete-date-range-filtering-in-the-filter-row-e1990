﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;


public class DateSelector : ITemplate
{
    public void InstantiateIn(Control container)
    {
        ASPxLabel lbl = new ASPxLabel();
        lbl.ID = "lblFrom";
        lbl.Text = "From:";
        container.Controls.Add(lbl);

        ASPxDateEdit dateFrom = new ASPxDateEdit();
        dateFrom.ID = "dateFrom";
        dateFrom.ClientInstanceName = "dFrom";
        dateFrom.Date = new DateTime(1950, 1, 1);
        container.Controls.Add(dateFrom);

        lbl = new ASPxLabel();
        lbl.ID = "lblTo";
        lbl.Text = "To:";
        container.Controls.Add(lbl);

        ASPxDateEdit dateTo = new ASPxDateEdit();
        dateTo.ID = "dateTo";
        dateTo.ClientInstanceName = "dTo";
        dateTo.Date = new DateTime(1960, 11, 30);
        container.Controls.Add(dateTo);

        ASPxButton btn = new ASPxButton();
        btn.ID = "btnApply";
        btn.Text = "Apply";
        btn.AutoPostBack = false;
        btn.ClientSideEvents.Click = "function (s, e) { ApplyFilter( dFrom, dTo ); }";
        container.Controls.Add(btn);
    }
}