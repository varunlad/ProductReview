using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo058
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDataTable
            //UC1
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Review="good",Rating=17,Islike=true},
                new ProductReview(){ProductId=2,UserId=6,Review="nice",Rating=11,Islike=true},
                new ProductReview(){ProductId=1,UserId=2,Review="bad",Rating=7,Islike=false},
                new ProductReview(){ProductId=9,UserId=10,Review="good",Rating=19,Islike=true},
                new ProductReview(){ProductId=10,UserId=2,Review="good",Rating=15,Islike=true},
                new ProductReview(){ProductId=10,UserId=2,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=8,UserId=3,Review="bad",Rating=10,Islike=false},
                new ProductReview(){ProductId=5,UserId=5,Review="good",Rating=9,Islike=false},
                new ProductReview(){ProductId=10,UserId=2,Review="good",Rating=8,Islike=false},
                new ProductReview(){ProductId=9,UserId=3,Review="good",Rating=7,Islike=false},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=19,Islike=true},
                new ProductReview(){ProductId=3,UserId=6,Review="bad",Rating=10,Islike=false},
                new ProductReview(){ProductId=5,UserId=7,Review="nice",Rating=15,Islike=true},
                new ProductReview(){ProductId=1,UserId=10,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=2,UserId=9,Review="good",Rating=16,Islike=true},
                new ProductReview(){ProductId=10,UserId=2,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=9,UserId=3,Review="bad",Rating=10,Islike=false},
                new ProductReview(){ProductId=8,UserId=4,Review="nice",Rating=13,Islike=true},
                new ProductReview(){ProductId=10,UserId=2,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=3,Islike=false},
                new ProductReview(){ProductId=2,UserId=8,Review="good",Rating=17,Islike=true},
                new ProductReview(){ProductId=10,UserId=10,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=5,UserId=10,Review="bad",Rating=9,Islike=false},
                new ProductReview(){ProductId=6,UserId=3,Review="nice",Rating=14,Islike=true},
                new ProductReview(){ProductId=10,UserId=10,Review="good",Rating=18,Islike=true},
                new ProductReview(){ProductId=1,UserId=7,Review="bad",Rating=2,Islike=false},
                new ProductReview(){ProductId=4,UserId=9,Review="bad",Rating=1,Islike=false},
                new ProductReview(){ProductId=8,UserId=8,Review="bad",Rating=3,Islike=false},
                new ProductReview(){ProductId=9,UserId=3,Review="good",Rating=20,Islike=true},
                new ProductReview(){ProductId=7,UserId=1,Review="bad",Rating=10,Islike=false},
                new ProductReview(){ProductId=6,UserId=5,Review="good",Rating=17,Islike=true},
            };
            DataTableDemo.CreateDataTable();
            ProductIdAverage(list);
            Console.ReadLine();
        }
        //UC1
        //Display The Records
        public static void IterateLoopList(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Product ID:" + product.ProductId + "\t User ID:" + product.UserId + "\t Review:" + product.Review + "\t Rating:" + product.Rating);
            }
        }
        //UC2
        //Retriving Top 3 Records from the List
        public static void RetriveTop3Records(List<ProductReview> list)
        {
            var result = (from product in list orderby product.Rating descending select product).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("After Sorting");
            IterateLoopList(result);
            var top3Records = result.Take(3).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("Top 3 Records");
            IterateLoopList(top3Records);
        }
        //UC3
        //retrive the record whose Rating is Greater than 3 and Product ID is Either 1 or 4 or 9
        public static void RetriveBasedonProductIdandRating(List<ProductReview> list)
        {
            var data = (list.Where(a => a.Rating > 3 && (a.ProductId == 1 || a.ProductId == 4 || a.ProductId == 9))).ToList();
            Console.WriteLine("The desire Result is :");
            IterateLoopList(data);
        }      
    }
}
