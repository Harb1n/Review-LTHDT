class SoPhuc
{
    // thành phần dữ liệu
    private double m_thuc;
    private double m_ao;

    //Phương thức tạo lập
    public SoPhuc()
    {
        m_thuc = 0;
        m_ao = 0;
    }
    public SoPhuc(double thuc, double ao)
    {
        m_thuc = thuc;
        m_ao = ao;
    }
    // Phương thức trả về dữ liệu của đối tượng ( Thực và Ảo)
    public double getThuc()
    {
        return m_thuc;
    }
    public double getAo()
    {
        return m_ao;

    }
    // Phương Thức cập nhật dữ liệu của đối tượng
    public void setSoPhuc(double thuc,double ao)
    {
        m_thuc = thuc;
        m_ao = ao;
    }
    // Các properties của Phần thực và phần ảo
    public double PhanThuc
    {
        get { return m_thuc; }
        set { m_thuc = value; }
    }
    public double PhanAo 
    {
        get { return m_ao; }
        set { m_ao = value; }

    }
    //Modun của số phức = -/(a)^2 + (b)^2
    public double Modun()
    {
        return Math.Sqrt(Math.Pow(m_thuc,2) +  Math.Pow(m_ao,2));
    }
    // Phương thức cộng 2 số phức sửu dụng this và a
    public SoPhuc cong(SoPhuc a)
    {
       SoPhuc s = new SoPhuc();
        
        s.m_thuc = this.m_thuc + a.m_thuc;
        s.m_ao = this.m_ao + a.m_ao;

        return s;
    }
    // test
    public static void Blah()
    {
        Console.WriteLine("This message appear as test");

    }
    // Phương thức cộng 2 số phức this và a
    public int sosanh(SoPhuc a)
    {
        if (this.Modun() > a.Modun()) return 1;
        else if(this.Modun() == a.Modun()) return 0;
        
        else if(this.Modun()==a.Modun()) return -1;
        return -1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc[] arrSoPhuc = new SoPhuc[] // khai báo 1 mảng
            {
                new SoPhuc(-3,1),
                new SoPhuc(1,5),
                new SoPhuc(-2, -2),
                new SoPhuc(0,5),
                new SoPhuc(8,0),
                new SoPhuc(9,-5),
                new SoPhuc(-7,-3),
                new SoPhuc(5,6),
            };

            Console.WriteLine("Count: {0}", demPhanthucDuong(arrSoPhuc)); // {0} chỗ để chứa dữ liệu
            SoPhuc operatorr = timSoPhuc(arrSoPhuc, 1, 5); // Nay khai báo hàm để tìm cái số phức trước
            Console.WriteLine("Find (1,5): ({0},{1})", operatorr.PhanThuc, operatorr.PhanAo);
            // sau khi tìm thấy thì cái operatorr nó hứng kết quả, rồi lấy phần thực với ảo của nó xuất ra
            operatorr = tongSoPhuc(arrSoPhuc);
            Console.WriteLine("Tong Phan thuc va phan ao la: ({0},{1})", operatorr.PhanThuc, operatorr.PhanAo);
            operatorr = maxSoPhuc(arrSoPhuc);
            Console.WriteLine("tim so phuc lon nhat: ({0},{1})", operatorr.PhanThuc, operatorr.PhanAo);
            // Hàm Tìm Số Dương
            static int demPhanthucDuong(SoPhuc[] ds)
            {
                // 1 là xài foreach 2 là xài for
                int count = 0;
                foreach (SoPhuc s in ds) // Hàm Foreach
                {
                    if (s.m_thuc > 0) count++;
                }
                //for(int i =0; i < ds.Length; i++)
                //{
                //    if (ds[i].m_thuc > 0) count++;
                //}
                return count;
            }
            // tim so phuc
            static SoPhuc timSoPhuc(SoPhuc[] ds, double a, double b)
            {


                foreach (SoPhuc s in ds)
                {
                    if (s.m_thuc == a && s.m_ao == b) return s;
                }
                return null;
            }
            // Tính tổng So phuc 
            static SoPhuc tongSoPhuc(SoPhuc[] ds)
            {
              SoPhuc sum = new SoPhuc();
                foreach (SoPhuc s in ds)
                {
                   sum = sum.cong(s);

                }

                return sum;
            }
            //Tinh Max so phuc
            static SoPhuc maxSoPhuc(SoPhuc[] ds)
            {
                SoPhuc max = new SoPhuc();
                max = ds[1];

                foreach(SoPhuc s in ds)
                {
                    if (max.Modun() < s.Modun()) max = s;
                }


                return max;
            }



        }
    }
}