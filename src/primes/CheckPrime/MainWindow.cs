using System;
using Gtk;
using libprimes;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void setResult(bool isPrime,int firstFactor)
    {
        firstFactorLbl.Text = firstFactor.ToString();

        if (isPrime) 
        {
            isPrimeResultImg.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
        }
        else
        {
            isPrimeResultImg.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-cancel", global::Gtk.IconSize.Menu);
        }

    }
    private void resetResult()
    {
        setResult(false, 0);
    }

    protected void checkIsPrime(object sender, EventArgs e)
    {
        resetResult();

        Prime pr = new Prime();
        if (primeTxt.Text.Trim().Equals("")) return;

        bool success= int.TryParse(primeTxt.Text.Trim(),out int prime);
        if (!success) return;
        int firstFactor;
        bool isPrime=pr.IsPrime(prime,out firstFactor);

        setResult(isPrime, firstFactor);
    }
}
