﻿using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using FormsToolkit.iOS;

[assembly: ExportRenderer (typeof(ImageCell), typeof(StandardImageCellRenderer))]
namespace FormsToolkit.iOS
{
    /// <summary>
    /// Standard image cell renderer.
    /// </summary>
    public class StandardImageCellRenderer : ImageCellRenderer
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }
        /// <summary>
        /// Gets the cell.
        /// </summary>
        /// <returns>The cell.</returns>
        /// <param name="item">Item.</param>
        /// <param name="reusableCell">Reusable cell.</param>
        /// <param name="tv">Tv.</param>
        public override UIKit.UITableViewCell GetCell (Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.SetDisclosure(item.StyleId);
            return cell;
        }
    }
}

