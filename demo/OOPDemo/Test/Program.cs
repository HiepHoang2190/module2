using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
          var  cbm = new CaBayMau("Ca Bay Mau", 10, true, "Colorful");
            cbm.CachBoi();
        }
    }
    public interface IBoi
    {
        void CachBoi();
    }
    public abstract class Ca:IBoi
    {
        #region fields
        private int CanNang { get; set; }
        private bool CoVay { get; set; }
        private string TenCa { get; set; }
        private string Mau { get; set; }
        #endregion

        #region constructor
        #endregion

        #region public method
        public Ca(string TenCa,int CanNang, bool CoVay,string Mau)
        {
            this.TenCa = TenCa;
            this.CanNang = CanNang;
            this.CoVay = CoVay;
            this.Mau = Mau;
        }
        public string TENCA
        {
            get => TenCa;
            set => TenCa = value;
        }
        public int CANNANG
        {
            get => CanNang;
            set => CanNang = value;
        }
        public bool COVAY
        {
            get => CoVay;
            set => CoVay = value;
        }

        public string MAU
        {
            get => Mau;
            set => Mau = value;
        }


        public virtual void CachBoi()
        {
            Console.WriteLine("Ca nao chang biet boi !!!");
        }
        #endregion
    }
    public class CaBayMau: Ca
    {
        public CaBayMau(string TenCa, int CanNang, bool CoVay, string Mau) : base(TenCa, CanNang, CoVay, Mau)
        {
            Console.WriteLine("Ca Bay Mau");
            Console.WriteLine($"Ten: {TenCa}");
            Console.WriteLine($"Can Nang: {CanNang}");
            Console.WriteLine($"Co Vay: {CoVay}");
            Console.WriteLine($"Mau: {Mau}");
        }

        public override void CachBoi()
        {
            base.CachBoi();
            Console.WriteLine("Boi loanh quanh tren mat nuoc");
        }
    }
}
