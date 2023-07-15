using Lab_08;

namespace TestLibrary
{
    public class UnitTest1
    {
        Backpack<string> backpack = new Backpack<string>();
        Library l1 = new Library();
        [Fact]
        public void Test1()
        {
          
            l1.Add("book", "Ahmad", "Ahmad", 500);
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void Test2()
        {

            l1.Add("book", "Ahmad", "Ahmad", 500);
            l1.Add("book1", "Ahmad", "Ahmad", 500);
            l1.Borrow("book");
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void Test3()
        {


            l1.Add("book", "Ahmad", "Ahmad", 500);

            Book borrowedBook = l1.Borrow("Book");

            Assert.DoesNotContain(borrowedBook, l1);

        }
        [Fact]
        public void Test4()
        {

            l1.Add("book", "Ahmad", "Ahmad", 500);
            l1.Add("book2", "Ahmad", "Ahmad", 500);
            Book book = l1.Borrow("book3");
            Assert.Equal(book, null);

        }
        [Fact]
        public void Test5()
        {

            l1.Add("book", "Ahmad", "Ahmad", 500);
            l1.Add("book2", "Ahmad", "Ahmad", 500);
            
            Book book = l1.Borrow("book2");
            l1.Return(book);

            Assert.Contains(book, l1);
        }
        [Fact]
        public void Test6()
        {

            l1.Add("book", "Ahmad", "Ahmad", 500);
            l1.Add("book2", "Ahmad", "Ahmad", 500);
            Book book = l1.Borrow("book2");
            l1.Return(book);
            int res = l1.Count;
            Assert.Equal(2, res);
        }
        [Fact]
        public void Test7()
        {
 
            backpack.Pack("book");
            Assert.Equal(1, backpack.Count());
        }
        [Fact]
        public void Test8()
        {
           
           
            backpack.Pack("book");
            string unpackedItem = backpack.Unpack(0);
            Assert.Equal("book", unpackedItem);
            Assert.Equal(0, backpack.Count());
        }


    }
}