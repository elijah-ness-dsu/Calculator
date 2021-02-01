// Credit for this control goes to Hans Passant
//https://stackoverflow.com/questions/5341650/right-alignment-of-items-in-windows-forms-listbox

using System;
using System.Drawing;
using System.Windows.Forms;

class ReverseListBox : ListBox
{
    public ReverseListBox()
    {
        this.DrawMode = DrawMode.OwnerDrawFixed;
    }
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        e.DrawBackground();
        if (e.Index >= 0 && e.Index < this.Items.Count)
        {
            var selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            var back = selected ? SystemColors.Highlight : this.BackColor;
            var fore = selected ? SystemColors.HighlightText : this.ForeColor;
            var txt = this.Items[e.Index].ToString();
            TextRenderer.DrawText(e.Graphics, txt, this.Font, e.Bounds, fore, back, TextFormatFlags.Right | TextFormatFlags.SingleLine);
        }
        e.DrawFocusRectangle();
    }
}
