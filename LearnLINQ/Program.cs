/*bool IsAnyword(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        bool final = true;
        foreach (var letter in word) {
            if (char.IsLower(letter))
            {
                final = false;
            }
        }
        if (final)
        {
            return true;
        }
    }
    return false;
}
var words = new[] { "red", "green", "blue" };
Console.WriteLine(IsAnyword(words));
Console.ReadLine(); */


/*var words = new[] { "red", "green", "blue" };
bool IsAnywordLinq(IEnumerable<string> words)
{
    return words.Any(word => word.All(letter => char.IsUpper(letter)));
}
Console.WriteLine(IsAnywordLinq(words));
Console.ReadLine();*/


using System.Collections.Concurrent;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;


/*bool isAnygraterThan100(int[] numbers)
{
    foreach(var number in numbers)
    {
        if (greater100(number))
        {
            return true;
        }
    }
    return false;
}
bool greater100(int number)
{
    return number > 100;
}
bool isEven(int[] numbers)
{
    foreach(var number in numbers)
    {
        if (isEvenno(number)) ;
        {
            return true;
        }

    }return false;
}
bool isEvenno(int number)
{
    return number%2==0;
}
var numbers = new[] { 1, 4, 5, 6, 7, 8, 5, 4, 233, 22, 324 };
Console.WriteLine("isAnygrater than 100" + isAnygraterThan100(numbers));
Console.WriteLine("is even" + isEven(numbers));
Console.ReadLine();*/



/*bool isgreaterthan100(int number)
{
    return number > 100;
}
bool isEven(int number)
{
    return (number % 2 == 0);
}
bool isAny(int[] numbers,Func<int, bool> predicate)
{
    foreach(var number in numbers)
    {
        if (predicate(number))
        {
               return true;
        }
    }
    return false;
}
var numbers = new[] { 1, 2, 3, 4, 5, 6, 33, 3455 };
bool isAnygreaterthan100 = isAny(numbers, isgreaterthan100);
bool isanyeven = isAny(numbers, isEven);

Console.WriteLine($"is greaterthan 100 {isAnygreaterthan100}");
Console.WriteLine($"is any ebven{isanyeven}");
Console.ReadLine(); */



//using generic

/*var numbers = new[] { 1, 2, 3, 0,4, 5, 6, 33, 3455 };
bool isAnyGeneric<T>(IEnumerable<T> numbers,Func<T, bool> predicate)
{
    foreach(var number in numbers)
    {
        if (predicate(number))
        {
               return true;
        }
    }
    return false;
}
var words = new[] { "red","green","blue"};
bool IsanyLength5 = isAnyGeneric(words,word =>word.Length==5);

bool isAnyZero = numbers.Any(x => x == 0);
Console.WriteLine($"is any zero  {isAnyZero}");
Console.WriteLine($"isany length 5 {IsanyLength5}");

Console.ReadLine();*/


/*var words=new List<string> { "a", "bb", "ccc", "dddd" };
var ShortWords = words.Where(x => x.Length < 3).ToList();//tolis meterializes so e is not added nxt iteration.
foreach (var word in ShortWords)
{
    Console.WriteLine(word);
}
words.Add("e");
foreach (var word in ShortWords)
{
    Console.WriteLine(word);
}
Console.ReadLine*/


/*var allpplare18 = people.Where(x => x.age > 18);
var take100 = allpplare18.take(100);*/



/*var names = new List<string> { "jhon", "mary", "bob", "jack" };
var namesStartsWithJ = names.Where(name =>
{
    Console.WriteLine("Checking names" + name);
    return name.StartsWith("j");
});
foreach(var name in namesStartsWithJ)
{
    Console.WriteLine($"{name}");

}
Console.ReadLine();*/




/*var numbers = new[] { 1, 10,3 ,12, 23, 234, 43, 2 };
var smallnumberMethodSyntax = numbers.Where(number => number < 5).OrderBy(number =>number);
Console.WriteLine(string.Join(", ",smallnumberMethodSyntax));
var samllnumberqurysyntax = from number in numbers where number < 5 orderby number select number;
Console.WriteLine(string.Join(", ",samllnumberqurysyntax));
Console.ReadLine();
*/


/*using LearnLINQ;

var anyGreater10 = Data.Numbers.Any(SqlXml => SqlXml > 10);
Console.WriteLine("anyGreater10"+anyGreater10);
Console.ReadLine(); */


using LearnLINQ;
var anyfoodmeat = Data.Food.Any(food => food.Name=="Meat");
Console.WriteLine("foodnamemeat\t" + anyfoodmeat);
var anyfoodChicken = Data.Food.Any(food => food.Name == "Chicken");
Console.WriteLine("foodnamechicken\t" + anyfoodChicken);
var anyFoodFruits = Data.Food.Any(food => food.FoodType == FoodType.Fruit);
Console.WriteLine("foodnamefruits\t" + anyFoodFruits);
var isNameLengthandOddId = Data.Food.Any(food => food.Name.Length > 8 && food.Id % 2 == 1);
Console.WriteLine("namelength and oddid"+isNameLengthandOddId);
var isNotEmpty = Data.Food.Any();
Console.WriteLine("is empty" + isNotEmpty);
var isallFoodPriced = Data.Food.All(x=>x.Price>0);
Console.WriteLine("foodpriced\t" + isallFoodPriced);
var isThereonlymeat = Data.Food.All(x=>x.FoodType==FoodType.Meat);
Console.WriteLine("foodonly meat?\t" + isThereonlymeat);
var count = Data.Food.Count(food => food.FoodType == FoodType.Meat );
Console.WriteLine("foodmeat count\t" + count );
var countcknmeat = Data.Food.Count(food => food.Name == "Chicken");
Console.WriteLine("foodcount ckn meat\t" + countcknmeat  );
var meatcheaperthansix = Data.Food.Count (food => food.FoodType == FoodType.Meat && food.Price<6);
Console.WriteLine("meat price less than 6\t"  + meatcheaperthansix );
var countfood = Data.Food.Count ();
Console.WriteLine("foodtotal count\t" + countfood );
var issixPresent = Data.Numbers.Contains(6);
Console.WriteLine("Contains 6\t" + issixPresent)   ;
var isLion = Data.Words.Contains("lion");
Console.WriteLine("Checks lion\t" + isLion );
var foodorderdbyname = Data.Food.OrderBy(x => x.Name);
Console.WriteLine("orderbynames\n" +string.Join("\n",foodorderdbyname)) ; 
var foodorderdbynamesdesc=Data.Food.OrderByDescending(x => x.Name);
Console.WriteLine("orderbynamesdescending \n" + string.Join("\n", foodorderdbynamesdesc ));
var orderdnumbers = Data.Numbers.OrderBy(number => number);
Console.WriteLine("orderbynummber" + string.Join(",", orderdnumbers) );
var foodorderedbytypethenname = Data.Food.OrderBy(Food => Food.FoodType).ThenBy(x => x.Name);
Console.WriteLine("foodorderedbytypethename\n" + string.Join("\n", foodorderedbytypethenname)) ;
var smallest = Data.Numbers.Min();
var lasgest=Data.Numbers.Max();
Console.WriteLine("smallest" + smallest);
Console.WriteLine("largest" + lasgest);
var minprice = Data.Food.Min(x => x.Price);
var maxprice = Data.Food.Max(x => x.Price);
Console.WriteLine("maxprice" + maxprice);
Console.WriteLine("minPrice" + minprice);
var minFood = Data.Food.Min();
Console.WriteLine("minfood" + minFood);
var average = Data.Numbers.Average();
Console.WriteLine("average of numbers" + average);
var avgfoodprice = Data.Food.Average(food => food.Price);
Console.WriteLine("average food price" + avgfoodprice);
var sumNumbers = Data.Numbers.Sum();
Console.WriteLine("sumnos" + sumNumbers);
var sumfoodprice = Data.Food.Sum(x => x.Price);
Console.WriteLine("sumfoodprice" + sumfoodprice);
var emptynos = new int[0];
var sumempty = emptynos.Sum();
Console.WriteLine("sumempty" + sumempty); 
var fistno = Data.Numbers[0];
Console.WriteLine("fistno" + fistno); 
var foodlistfirst=Data.Food.ToList();   
Console.WriteLine("fist food" + foodlistfirst[0]);
var noindex = Data.Food.ElementAtOrDefault (100);
Console.WriteLine("noindex" + noindex);
var vegetableslast = Data.Food.Last(x => x.FoodType == FoodType.Vegetables);
Console.WriteLine("last vegetables" + vegetableslast);
var lastfoodover100 = Data.Food.LastOrDefault(x => x.Price > 100);
 Console.WriteLine("lastfoodover100" + lastfoodover100 );
var mostexxpensivefood = Data.Food.OrderBy(x => x.Price).Last();
Console.WriteLine("mostexpesivefood" + mostexxpensivefood );
var singlegreater100 = Data.Numbers.SingleOrDefault (x => x > 100);
Console.WriteLine("singlegreaterthan100\t  "+singlegreater100);
var allevennumbers=Data.Numbers.Where(x=>x%2==0  && x>300);   
Console.WriteLine("alleven"+string.Join(",", allevennumbers)) ;
var specificfood = Data.Food.Where(x => (x.FoodType == FoodType.Fruit || x.FoodType == FoodType.Vegetables) && x.Price < 2 && x.Id % 2 == 1);
Console.WriteLine("verySpecificFood"+String.Join("\n", specificfood)) ;
var selectedindexs = new[] { 0, 3 ,2 };
var selectedindexes = Data.Food.Where((food,index)=>food.Price<4 && selectedindexs.Contains(index) );
Console.WriteLine("foodindexes" + String.Join("\n", selectedindexes ));
var countofexpensivefood = Data.Food.Where(x => x.Price > 4).Count();
var countofexpensivefood2 = Data.Food.Count(x => x.Price > 4);
Console.WriteLine("count" + countofexpensivefood +"count "+countofexpensivefood2);
var first3 = Data.Numbers.Take(3);
Console.WriteLine("fisrt 3 \n "+string.Join("\n",first3)) ;
var skipthree=Data.Numbers.Skip(3);
Console.WriteLine("skip three\n "+string.Join ("\n",skipthree)) ; 
var thridandfourthfood= Data.Food.Skip(2).Take(2);
Console.WriteLine("get 3rd and 4th \n" + string.Join("\n", thridandfourthfood));

var objects = new Object [] { 1, "red", 2, "green", new List<int>(), "blue", true };
var strings = objects.OfType<string>();
Console.WriteLine("strings \n"+string.Join("\n",strings));
var append = Data.Numbers.Append(1000);
var  prepaemd = Data.Numbers.Prepend(2000);
Console.WriteLine("append\n"+string.Join("\n", append));
Console.WriteLine("prepend\n" + string.Join("\n", prepaemd ));

var doublenos = Data.Numbers.Select(x => x * 2);
Console.WriteLine("double numbers "+string.Join("\n",doublenos));

var maketoupper = Data.Words.Select(x => x.ToUpper());
Console.WriteLine(string.Join("\n", maketoupper));
var numberdwords = Data.Words.Select((x, index) => $"{index}. {x}");
Console.WriteLine(string.Join("\n", numberdwords));
var doofoverone = Data.Food.Where(food => food.Price > 1).Select(food => food.FoodType).Distinct();
 Console.WriteLine(string.Join("\n", doofoverone));

var peoplefood = Data.People.SelectMany(x => x.Food);
Console.WriteLine("peoplefood"+string.Join("\n", peoplefood));
var peoplenamej = Data.People.Where(x => x.Name.StartsWith('J')).SelectMany(x => x.Food).Select(x => x.Name) ;
Console.WriteLine("name startswith j" + string.Join("\n", peoplenamej));

var nestedlistofnumbers = new List<List<int>>
 {
     new() {1,2,3},
     new() {4,5,6},
     new() {6,7,8},
 };
var sum = nestedlistofnumbers.SelectMany(x => x).Sum();
Console.WriteLine("sumoflist"+sum);
var varynestedlistofnumbers = new List<List<List<int>>>

 {
     new(){
     new() {1,2,3},
     new() {4,5,6},
     new() {6,7,8},
    },
     new(){
     new() {1,2,3},
     new() {4,5,6},
     new() {6,7,8},
    },
 };
var sum2=varynestedlistofnumbers.SelectMany(x => x).SelectMany(x=>x).Sum();    
Console.WriteLine("sum" + sum2);
var personfoodinfo = Data.People.SelectMany(person => person.Food, (person, food) => $"{person.Name}likes {food.Name}");
Console.WriteLine("peopelefoodinformation\n" + string.Join("\n", personfoodinfo)); 
 var emptyints=Enumerable.Empty<int>();
if (!emptyints.Any()) Console.WriteLine("empty");
var tencopis = Enumerable.Repeat(1, 10);
Console.WriteLine("TENCOPIES " + string.Join(",", tencopis));
var copies = Enumerable
        .Repeat("banana",4)
        .Select((x,i) => $"{i+1}.{x}");
Console.WriteLine(
    "copieswithi dex\n    "+string.Join(",", copies));
var printrage = Enumerable.Range(1, 10);
Console.WriteLine("oneto10"+string.Join(",", printrage));
var defaultempty = Data.Numbers.DefaultIfEmpty();
Console.WriteLine("defaultempty?" + string.Join(",", defaultempty));


var groupings = Data.Food.
        GroupBy(
        food => food.FoodType,
        food => food.Price);
var sumofpricesbytype = groupings
                        .ToDictionary(x => x.Key 
                        , x => x.Sum());
Console.WriteLine("summ" +string.Join(",",  sumofpricesbytype));

var lookuofoodprice = Data.Food.
       ToLookup(
       food => food.FoodType,
       food => food.Price);
var sumofpricesbytype2 = lookuofoodprice
                        .ToDictionary(lookup => lookup.Key
                        , Lookup => Lookup.Sum());
Console.WriteLine("summ2" + string.Join(",",sumofpricesbytype2 ));
var numbers1 = new[] {1,2,3,4,5,6,7,8,9};
var numbers2= new[] {1,3,4,5,6,7,9};
var numbersIntersect = numbers1.Intersect(numbers2);
Console.WriteLine("numbersIntersect\t"+string.Join(",",numbersIntersect));
 var except=numbers1.Except(numbers2);  
Console.WriteLine("except"+string.Join(",",except));
var Countexpensive = Data.Food.Where(x => x.Price > 4).Count();
var countexpensive2 = Data.Food.Count(x => x.Price>4); 
Console.WriteLine("countecpensive" + Countexpensive); 
Console.WriteLine("countexpesive2" + countexpensive2);

var sumofnos = Data.Numbers.Aggregate ((sum, nextnumbers) =>  sum + nextnumbers);
Console.WriteLine("sum"+string.Join(",",  sumofnos)) ;
var words = "red green bluee";
var longwords = words.Split(" ").Aggregate((longestSoFar, nextWord) => nextWord.Length > longestSoFar.Length ? nextWord: longestSoFar);
Console.WriteLine("longestwords"+  longwords ) ;
var jointwords = Data.Words.Aggregate((resultsofar, next) => resultsofar + ", " + next);
Console.WriteLine("jointwords" + jointwords); 
var alllegth=words.Split(' ').Aggregate(Enumerable.Empty<int>(),
    (lengthcollection,next)=>lengthcollection.Append(next.Length));
Console.WriteLine("all Length\n" + string. Join("\n ", alllegth));
var numberzipped = Data.Numbers.Zip(Data.Words, (number, word) => $"{number},{word}");
Console.WriteLine("NUBERZIPPED\n" + string.Join("\n", numberzipped));
var orderednos = from number in Data.Numbers
                 orderby number 
                 select number;
Console.WriteLine("order\n"+string.Join ("\n", orderednos));
var orderFoodByTypeAndId = from food in Data.Food
                           orderby food.FoodType, food.Id
                           select food;
                            

Console.WriteLine("orderbyfoodtypeid\n"+string.Join("\n", orderFoodByTypeAndId));

var enennumbers = from number in Data.Numbers
                  where number % 2 == 0
                  orderby number descending
                  select number;
var specifiedFood = from food in Data.Food
                    where (food.FoodType == FoodType.Meat || food.FoodType == FoodType.Fruit)
                          && food.Price > 1
                          && food.Name.Length > 4
                    select food;

Console.WriteLine("Specified food:\n" + string.Join("\n", specifiedFood));
 
var wordsUppercase=from word in Data.Words
                   select word.ToUpper();
Console.WriteLine("wordsUppercase\n"+string.Join("\n",wordsUppercase));
var foodprceover1 = from food in Data.Food
                    where food.Price > 1
                    select food.FoodType;
Console.WriteLine("over1\n" + string.Join("\n", foodprceover1 ));
var foodinfo=from food in Data.Food
             orderby food.Name
             select $"{food.Name.First()}. "+
             $"{food.FoodType}"+
             $"{food.Price}";
Console.WriteLine("foodinfo\n" + string.Join("\n", foodinfo));


var nestedlist = new List<List<int>>
{
    new() {1,2,3},
    new() {1,2,3 },
    new() {1,2,3},
};
var nestedlists = from list in nestedlist
                  from number in list
                  select number;
Console.WriteLine("nested list\n" + string.Join("\n", nestedlists));

var pplfood = from person in Data.People
              where person.Name.StartsWith('J')
              from food in person.Food
              select food;
Console.WriteLine("pplfood\n" + string.Join("\n", pplfood)); 

var innerjoin = from person in Data.People 
                join reservation in Data.Reservations
                on person.Id equals reservation.PersonId
                select $"{person.Name}has a reservation on" + $"{reservation.Date}";
Console.WriteLine("innerjoin\n" + string.Join("\n", innerjoin));
var innerjoin3 = from person in Data.People
               join reservation in Data.Reservations
               on person.Id equals reservation.PersonId
               join restraunt in Data.Restaurants
               on reservation.RestaurantId equals restraunt.Id
               select $"{person.Name}has a reservation on" + $"{reservation.Date}"+$"at name{restraunt.Name}";
Console.WriteLine("innerjoin3 \n" + string.Join("\n", innerjoin3));


Console.ReadLine();           