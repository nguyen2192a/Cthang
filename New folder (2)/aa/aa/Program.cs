using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    class Program
    {
        static void Main(string[] args)
        {
            TransactionDAO dao = new TransactionDAO();

            do
            {
                Console.WriteLine("Nhap 1: Add");
                Console.WriteLine("Nhap 2: List");
                Console.WriteLine("Nhap 3: Search by code");
                Console.WriteLine("Nhap 4: Quit");
                int choose = Wrapper.GetInt("Nhap chuc nang");

                switch (choose)
                {
                    case 1:
                        Transaction trans = new Transaction();
                        Account a;
                        trans.Code = Wrapper.GetInt("Nhap code");
                        do
                        {
                            Console.WriteLine("Nhap 0: Tien nuoc");
                            Console.WriteLine("Nhap 1: Tien dien");
                            trans.Transactiontype = Wrapper.GetInt("Nhap type");
                            if (trans.Transactiontype == 0)
                            {
                                a = new WaterAccount();
                                break;
                            }
                            else if (trans.Transactiontype == 1)
                            {
                                a = new ElectronicAccount();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nhap 0 hoac 1");
                            }
                        } while (true);

                        trans.Transactiondate = Wrapper.GetDate("Nhap ngay thu tien");
                        trans.Total = Wrapper.GetDouble("Nhap so tien");

                        a.Code = trans.Code;
                        a.Month = Wrapper.GetInt("Nhap thang");
                        a.Name = Wrapper.GetString("Nhap ten");
                        a.Address = Wrapper.GetString("Nhap dia chi");
                        a.Total = trans.Total;
                        trans.Acc = a;
                        dao.Create(trans);
                        break;
                    case 2:
                        if (dao.ReadAll() == null)
                        {
                            Console.WriteLine("Danh sach trong");
                        }
                        else
                        {
                            Console.WriteLine("Danh sach :");
                            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
                                  "Code", "Month", "Name", "Address", "Total", "Type", "Date");
                            foreach (Transaction s in dao.ReadAll())
                            {
                                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
                                    s.Acc.Code, s.Acc.Month, s.Acc.Name, s.Acc.Address, s.Acc.Total, s.Acc.Type, s.Transactiondate.ToString("dd/M/yyyy"));
                            }
                        }
                        break;
                    case 3:
                        int code = Wrapper.GetInt("Nhap code de tim kiem: ");
                        if (dao.SearchByCode(code) == null)
                        {
                            Console.WriteLine("Danh sach trong");
                        }
                        else
                        {
                            Console.WriteLine("Tim thay :");
                            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
                                  "Code", "Month", "Name", "Address", "Total", "Type", "Date");

                            Transaction s = dao.SearchByCode(code);
                            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
                                s.Acc.Code, s.Acc.Month, s.Acc.Name, s.Acc.Address, s.Acc.Total, s.Acc.Type, s.Transactiondate.ToString("dd/M/yyyy"));

                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap chuc nang tu 1 den 4");
                        break;
                }
            } while (true);
        }
    }
}
