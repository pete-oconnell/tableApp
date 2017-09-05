﻿using System;
using System.Collections.Generic;
using System.IO;
using Foundation;
using UIKit;

namespace tableApp
{
    public class TableSource : UITableViewSource
    {
        string[] tableItems;
        string CellIdentifier = "TableCell";
        ViewController owner;

        public TableSource(string[] items, ViewController owner)
        {
            tableItems = items;
            this.owner = owner;
        }

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			string item = tableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(okAlertController,true,null);
            tableView.DeselectRow(indexPath, true);
		}
    }
}
