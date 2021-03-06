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
            NiceReview(list);
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
        //UC4
        //Counting Each ID present in the List
        public static void CountingID(List<ProductReview> list)
        {
            var data = (list.GroupBy(a => a.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() }));
            Console.WriteLine("Count of Each Product Id is: ");
            foreach (var element in data)
            {
                Console.WriteLine("Product ID: " + element.ProductId + "\t Count: " + element.count);
                Console.WriteLine("========================================================");
            }
        }
        //UC5
        //Retrive only ProductID and Review from the Records
        public static void ProductIdandReview(List<ProductReview> list)
        {
            var p = list.Select(product => new { ProductId = product.ProductId, review = product.Review }).ToList();
            foreach (var element in p)
            {
                Console.WriteLine("Product ID: " + element.ProductId + "\t Review: " + element.review);
                Console.WriteLine("=====================================");
            }
        }
        //UC6
        //Skip top 5 Records 
        public static void SkipTop5Records(List<ProductReview> list)
        {
            var result = (from product in list orderby product.Rating descending select product).ToList();
            Console.WriteLine("After Sorting");
            IterateLoopList(result);
            var skipTop5Records = result.Skip(5).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("Skip Top 5 Records");
            IterateLoopList(skipTop5Records);
        }
        //UC7
        //Retrive only ProductID and Review from the Records
        public static void ProductIdandReviewUC7(List<ProductReview> list)
        {
            var p = list.Select(product => new { ProductId = product.ProductId, review = product.Review }).ToList();
            foreach (var element in p)
            {
                Console.WriteLine("Product ID: " + element.ProductId + "\t Review: " + element.review);
                Console.WriteLine("=====================================");
            }
        }
        //UC10
        //Find Average according to Review
        //public static void ProductIdAverage(List<ProductReview> list)
        //{
        //    var data = (list.GroupBy(a => a.ProductId).Select(x => new { ProductId = x.Key, Rating = x.Average() }));
        //   //var data = (list.Select(a => a.ProductId).Select(c => new { Rating = c.Average() }));
        //    Console.WriteLine("Average of Each Product Id is: ");
        //    foreach (var element in data)
        //    {
        //        Console.WriteLine("Product ID: " + element.ProductId + "\t : " + element.average);
        //        Console.WriteLine("========================================================");
        //    }
        //}
        //UC11
        //Retrive data whose Review is Nice
        public static void NiceReview(List<ProductReview> list)
        {
            var data = (list.Where(a => a.Review == "nice")).ToList();
            IterateLoopList(data);
        }
    }
}
