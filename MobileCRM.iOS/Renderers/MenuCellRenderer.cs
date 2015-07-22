using MobileCRM.CustomControls;
using MobileCRM.Helpers;
using MobileCRM.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportCell(typeof(MenuCell), typeof(MenuCellRenderer))]

namespace MobileCRM.iOS
{

    public class MenuCellRenderer : ImageCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cellView = base.GetCell(item, reusableCell, tv);

            cellView.BackgroundColor = Color.Transparent.ToUIColor();

            //cellView.TextLabel.TextColor = Color.FromHex("FFFFFF").ToUIColor();
            cellView.TextLabel.TextColor = AppColors.LABELWHITE.ToUIColor();
            
            //cellView.DetailTextLabel.TextColor = Color.FromHex("AAAAAA").ToUIColor();
            cellView.DetailTextLabel.TextColor = AppColors.LABELBLUE.ToUIColor();

            //tv.SeparatorColor = Color.FromHex("444444").ToUIColor();
            tv.SeparatorColor = AppColors.SEPARATOR.ToUIColor();

            return cellView;
        }
    }
}
