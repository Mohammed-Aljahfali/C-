using System.Buffers;

namespace ExercisesOne_with_En.Ahalm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. اكتب برنامج لإيجا د اكبر واصغر عنصر داخل المصفوفات ؟
            /*int[] arrays={ 12,20, 10, 50, 30, 40, 70, 100 };
            int minValueInArray = arrays[0];
            int maxValueInarray = arrays[0];
            for (int i = 0; i < arrays.Length; i++) {
                if (arrays[i] < minValueInArray)
                {
                    minValueInArray = arrays[i];
                }
                else if (arrays[i]>maxValueInarray)
                {
                    maxValueInarray = arrays[i];
                }
                
            }
            Console.WriteLine("The Min Vaule is :"+minValueInArray);
            Console.WriteLine("The Max Value is :"+maxValueInarray);
            */

            //2. اكتب برنامج لطباعه لاستقبال عناصر المصفوفه من المستخدم ثم طباعة عناصرها بالترتيب
            //العكسي ؟
            /*int[] arrays2 = new int[10];
            int n = arrays2.Length;
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter The Atimes To the array :>");
                arrays2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >=0; i--) {
                Console.Write(" "+arrays2[i]);
            }*/


            //اكتب برنامج لمقارنة مصفوفتين بالحجم وبجميع العناصر ؟.3
            /*int[] arr1 ={ 1, 2, 3, 3, 8, 6, 5, 5, 10, 8 };
            int[] arr2 = { 5, 3, 7, 3, 8, 16, 15, 5, 100,1};
            int[] arr3 = new int[arr1.Length];
            int n1 = arr1.Length;
            int n2=arr2.Length;
            if (n1 == n2)
            {
                Console.WriteLine("\n\n-----------------------------------------------------------------");
                Console.WriteLine("\n\nThe array one is aqual array two #@!!!!!!");
                Console.Write("{");
                for (int i = 0; i<n1; i++)
                {
                    for (int j = 0; j<n2; j++)
                    {
                        if (arr1[i] == arr2[j])//
                        {
                            arr3 [j] = arr2[j];
                        }
                        else {}
                    }
                    Console.Write(" "+arr3[i]+" , ");            
                }
                Console.WriteLine("}");
            }
            else
            {
                Console.WriteLine("The array one is not equal  array two :>)");
            }*/


            //4. اكتب برنامج لحساب كل عنصر في المصفوفة بجميع العناصر التي قبله ؟
            /*int[] arraysumItems = { 1, 2, 3, 5, 4, 6, 4, 20, 8, 10 };
            for (int i = 0; i < arraysumItems.Length; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    arraysumItems[i]=i+j;//1 1 3 5 7 9 11 13 15 17
                }
                Console.Write(" "+arraysumItems[i]);
            }*/


            //المصفوفة الثنائي ة 
            //5. اكتب برنامج لطباعة حساب مجموع كل صف على حده ؟
            /*int[,] twodinmatialarray = { { 1, 2, 3, 4 }, { 5, 6, 7,8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            for (int i = 0; i < twodinmatialarray.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < twodinmatialarray.GetLength(0); j++)
                {
                    sum+=twodinmatialarray[i, j];
                }
                Console.WriteLine(sum);
            }*/


            //6. اكتب برنامج لاستقبال العناصر من المستخدم ثم طباعه مضاعفة كل عنصر في المصفوفة ؟

            /*int[,] matrix = new int[3, 4];
            Console.WriteLine("\n------------------------------------------------------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j<matrix.GetLength(0); j++)
                {
                    Console.WriteLine("Enter The items to the array matrix >>>>");
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                Console.Write("{");
                for(int j = 0; j<matrix.GetLength(0); j++)
                {
                    int mult = 1;
                    mult*=matrix[i,j];
                    matrix[i,j] = mult*mult;
                    Console.Write(" "+matrix[i,j]+",");
                }
                Console.Write("}");
                Console.WriteLine();
            }*/

            //7. اكتب برنامج يطلب من المستخدم ادخال رقم ثم يقوم بجمع عدد العناصر الأكبر من هذا الرقم ؟
            /*int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.WriteLine("Enter the items number to an array matrix >>>>");
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("================>> print array <<======================= ");
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                Console.Write("{");
                for(int j = 0;j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j]+",");
                }
                Console.Write("}");
                Console.WriteLine();
            }
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Enter The number >>");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0;i < matrix.GetLength(0); i++)//row
            {
                int sum = 0;
                int avrnumber = 0;
                for(int j = 0;j < matrix.GetLength(0); j++)//culn
                {
                    if (matrix[i, j]>number)
                    {
                        sum +=matrix[i, j];
                        avrnumber++;
                    }
                }
                Console.WriteLine(""+number +"\tavragnumber="+avrnumber+"\t sum ="+sum);
            }*/

            //8. اكتب برنامج للبحث عن العنصر الأكثر تكرارا في المصفوفة ؟
            /*int [,]matrix= { { 10, 12, 10, 14 },{ 2, 3, 4, 5}, { 1, 2, 3, 2 } };
            int mostFrequent = matrix[0, 0];
            int maxFrequency = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    int current = matrix[i, j];//0 0 
                    int count = 0;
                    for(int k = 0; k < matrix.GetLength(0); k++)
                    {
                        for(int l = 0; l < matrix.GetLength(0); l++)
                        {
                            if (matrix[k, l] == current)//0=0 
                            {
                                count++;
                            }
                        }
                    }
                    if (count > maxFrequency)
                    {
                        mostFrequent = current;
                        maxFrequency = count;
                    }
                    Console.WriteLine("\n"+maxFrequency +"\t"+mostFrequent);
                }
            }*/

            //القوائم 
            //9. اكتب برنامج واحد باستخدام القوائم يقوم بعمل إضافة ، وحذف ، وبحث ، وفرز ، وحساب
            // المتوسط ، وطباعه العناصر بشكل عكسي لأرقام الى القائمة بحيث تكزن العمليات عن طريق المستخدم
            /*List<int> number = new List<int>();
            bool x=true;
            while (x)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("[1] Add a value to the list");
                Console.WriteLine("[2] Remove a value from the list");
                Console.WriteLine("[3] Search for a value in the list");
                Console.WriteLine("[4] Sort the items in the list or reverse itmes ");
                Console.WriteLine("[5] Calculate the average of the list items");
                Console.WriteLine("[6] Print the list items");
                Console.WriteLine("[7] Exit the program");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("choose the number from the list >>>");
                int chooseNumber = int.Parse(Console.ReadLine());
                switch (chooseNumber)
                {
                    case 1:
                        {
                            Console.WriteLine("What do you number items you want to add to the list >>>");
                            int itemsAdd = int.Parse(Console.ReadLine());
                            for (int i = 0; i < itemsAdd; i++)
                            {
                                Console.WriteLine("Enter the number items =>:");
                                int items = int.Parse(Console.ReadLine());
                                number.Add(items);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please enter the value you want to remove from the list:>>>");
                            int removeitems = int.Parse(Console.ReadLine());
                            if (number.Remove(removeitems))
                            {
                                Console.WriteLine($"The value '{removeitems}' is found in the list.");
                            }
                            else
                            {
                                Console.WriteLine($"The value '{removeitems}' is not found in the list.");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter the value you want to search for in the list:>>>");
                            int searchValue = int.Parse(Console.ReadLine());
                            if (number.Contains(searchValue))
                            {
                                Console.WriteLine($"The value '{searchValue}' is found in the list.");
                            }
                            else
                            {
                                Console.WriteLine($"The value '{searchValue}' is not found in the list.");
                            }
                            break;
                        }
                    case 4:
                    {
                            Console.WriteLine("Would you like to sort the list in ascending or descending order? (Enter 'asc'==1 for ascending, 'desc'==2 for descending)");
                            int sortItems = int.Parse(Console.ReadLine());
                            if (sortItems ==1)
                            {
                                number.Sort();
                                Console.WriteLine("The list has been sorted in ascending order:");
                            }
                            else if (sortItems ==2)
                            {
                                number.Sort();
                                number.Reverse();
                                Console.WriteLine("The list has been sorted in descending order:");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'asc'==1 or 'desc'==2.");
                            }
                            foreach (int item in number)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                    }
                    case 5:
                        {
                            int avrage = 0;
                            foreach (int i in number)
                            {
                                avrage+=i;
                                Console.WriteLine(i);
                            }
                            int avrg = avrage/number.Count();
                            Console.WriteLine("\n"+avrage+"The average of items in list  is = "+avrg);
                            break;
                        }
                    case 6:
                        {

                            foreach (int value in number)
                            {
                                Console.WriteLine(value);
                            }
                            break;
                        }
                    case 7:
                        {
                            if (chooseNumber==7)
                            {
                                x=false;
                                
                            }
                            break;
                        }
                }
            }*/


            //. اكتب برنامج واحد باستخدام القاموس يقوم بعمل إضافة ، وحذف ، وبحث ، تحديث ، عرض
            //المفاتيح والقيم ، وطباعه العناصر بشكل عكسي لأرقام الى القائمة بحيث تكزن العمليات عن
            //طريق المستخدم ؟

            /* Dictionary<int,int> UserDictionary = new Dictionary<int, int>();


             while (true)
             {
                 Console.WriteLine("---------------------------------------------------");
                 Console.WriteLine("Options:");
                 Console.WriteLine("[1] Add a value to the dictionary");
                 Console.WriteLine("[2] Remove a value from the dictionary");
                 Console.WriteLine("[3] Search for a value in the dictionary");
                 Console.WriteLine("[4] Sort the items in the dictionary and reverse  ");
                 Console.WriteLine("[5] Print the dictionary items");
                 Console.WriteLine("[6] Exit from the program");
                 Console.WriteLine("---------------------------------------------------");
                 Console.WriteLine("chiose the number from the list >>>");
                 int chioseNumber = int.Parse(Console.ReadLine());
                 switch (chioseNumber)
                 {
                     case 1:
                         {
                             while (true)
                             {
                                 Console.WriteLine("Enter The key :");
                                 int key = int.Parse(Console.ReadLine());
                                 if (UserDictionary.ContainsKey(key))
                                 {
                                     Console.WriteLine("The Key is Alreaddy exists. Please Enter a different key ");
                                     continue;
                                 }
                                 Console.WriteLine("Enter Vuale Here :");
                                 int value=int.Parse(Console.ReadLine());
                                 UserDictionary.Add(key, value);
                                 Console.WriteLine("The Item was successfuly added to dictionary +><+");
                                 Console.WriteLine("Do you want to add another item to dictionary (yes /no):>>>");
                                 string continueInput = Console.ReadLine();
                                 if (continueInput.ToLower()!="yes")
                                 {
                                     break;
                                 }
                                 else
                                 {
                                     Console.WriteLine("\nView dictionary contents ");
                                     int index = 1;
                                     foreach(var item in UserDictionary)
                                     {
                                         Console.WriteLine($"[{index++}]. key:{item.Key} => value:{item.Value}");
                                     }
                                 }
                             }                           
                             break;
                         }
                     case 2:
                         {
                             Console.WriteLine("Enter The key you want to delete or remove from the dictionary :>>");
                             int  keyToDelete= int.Parse(Console.ReadLine());
                             if (UserDictionary.Remove(keyToDelete))
                             {
                                 Console.WriteLine($"The item has been '{keyToDelete}' successfully delete from  a dictionary :)");
                             }
                             else
                             {
                                 Console.WriteLine($"There is no component  : '{keyToDelete}' in the dictionary in this key");
                             }
                             break;
                         }
                     case 3:
                         {
                             Console.WriteLine("Enter the key you want to search for :>>>");
                             int keyToSearch = int.Parse(Console.ReadLine());
                             if (UserDictionary.TryGetValue(keyToSearch,out int value))
                             {
                                 Console.WriteLine($"The key '{keyToSearch}  and value =>{value}' is found in the dictionary.");
                             }
                             else
                             {
                                 Console.WriteLine($"There is no component : '{keyToSearch}' is the dictionary in this key");
                             }
                             break;
                         }
                     case 4:
                         {
                             while (true)
                             {
                                 Console.WriteLine("\nChoose sorting type:");
                                 Console.WriteLine("1. Ascending by Key");
                                 Console.WriteLine("2. Descending by Key");
                                 Console.WriteLine("3. Ascending by Value");
                                 Console.WriteLine("4. Descending by Value");
                                 Console.WriteLine("5. Exit");

                                 Console.Write("Your choice: ");
                                 string choice = Console.ReadLine();

                                 switch (choice)
                                 {
                                     case "1":
                                         Console.WriteLine("\nDictionary sorted in ascending order by Key:");
                                         foreach (var item in UserDictionary.OrderBy(entry => entry.Key))
                                         {
                                             Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                                         }
                                         break;

                                     case "2":
                                         Console.WriteLine("\nDictionary sorted in descending order by Key:");
                                         foreach (var item in UserDictionary.OrderByDescending(entry => entry.Key))
                                         {
                                             Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                                         }
                                         break;

                                     case "3":
                                         Console.WriteLine("\nDictionary sorted in ascending order by Value:");
                                         foreach (var item in UserDictionary.OrderBy(entry => entry.Value))//Lambda Expression
                                         {
                                             Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                                         }
                                         break;

                                     case "4":
                                         Console.WriteLine("\nDictionary sorted in descending order by Value:");
                                         foreach (var item in UserDictionary.OrderByDescending(entry => entry.Value))
                                         {
                                             Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");                                           
                                         }
                                         break;

                                     case "5":
                                         Console.WriteLine("Goodbye!");
                                         return;

                                     default:
                                         Console.WriteLine("Invalid choice. Please try again.");
                                         break;
                                 }
                             }
                         }
                     case 5:
                         {

                             Console.WriteLine("\nView dictionary contents ");
                             int index = 1;
                             foreach (var item in UserDictionary)
                             {
                                 Console.WriteLine($"[{index++}]. key:{item.Key} => value:{item.Value}");
                             }
                             break;
                         }
                     case 6:
                         {
                             Console.WriteLine("Goodbye!");
                             return;
                         }
                     default : Console.WriteLine("Invalid choice. Please try again."); break;
                 }
             }*/

            // البرمجة الكائنية 
            //11. اكتب برنامج لنظام لإدارة حديقة حيوانا ت

            /*ManagementSystem managementSystem1=new ManagementSystem();

            while (true)
            {
                Console.WriteLine("\nZoo Management System:");
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. View Animals");
                Console.WriteLine("3. Search Animal");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("What do you want to  add Animal data choice (1=Mammal Animal / 2=Bird Animal ) :>>");
                        int choices=int.Parse(Console.ReadLine());
                        if(choices == 1)
                        {
                            managementSystem1.AddMammal();
                        }
                        else
                        {
                            managementSystem1.AddBirds();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("What do you want to  View or print Animal data choice (1=Mammal Animal / 2=Bird Animal ) :>>");
                            int choic = int.Parse(Console.ReadLine());
                            if (choic == 1)
                            {
                                managementSystem1.ViewMammal();
                            }
                            else
                            {
                                managementSystem1.ViewBird();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("What do you want to  Search Animal  data choice (1=Mammal Animal / 2=Bird Animal ) :>>");
                            int choi = int.Parse(Console.ReadLine());
                            if (choi == 1)
                            {
                                managementSystem1.SearchMammal();
                            }
                            else
                            {
                                managementSystem1.SearchBird();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exiting...");
                            return;
                        }
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }*/

            //ماهي مخرجات الاكواد التالية مع ذكر السبب وإيجاد الحل اذا وج دت مشكلة
            //12. ماهي مخرجات التالي مع ذكر السبب وإيجاد الحل اذا وجد مشكلة
           
            float a = 2.2F;//f and F ==> data type float
            float b = 3.3f;
            double c = 4.4;
            double d = 5.5D;// D and d ==> data type double 
            double e = 6.6d;
            decimal f = 7.7M;// M and m ==>data type decimal 10^10
            decimal g = 8.8m;
            Console.WriteLine("sum = " + (f + g));//15.5
            Console.WriteLine("sum = " + (d + e));//12.1
            Console.WriteLine("sum = " + (a + b + c));//9.9
            Console.WriteLine("sum = " + (a + b + c + d + e));//22
            //Console.WriteLine("sum = "+(a+b+c+d+e+f+g));//لا يمكن الجمع بين decimal وdouble مباشرةً. 
            //ولكن يمكننا  ان نحول من عشري الى عدد صحيح و العكس صحيح 
            Console.WriteLine("sum = " + ((decimal)a + (decimal)b + (decimal)c + (decimal)d + (decimal)e + f + g));//38.5
            Boolean v1 = true;
            Boolean v2 = false;
            Console.WriteLine($"{v1}\n{v2}");//true \n false
            Console.ReadKey();


        }
    }
    public abstract class Animal
    {
        private int id;
        private string name;
        private int age;
        private string gender;

        public Animal(int id, string name, int age, string gender)
        {
            this.id=id;
            this.name=name;
            this.age=age;
            this.gender=gender;
        }

        public int PropertiesID
        {
            get { return id; }
            set { id=value; }
        }
        public string NamePropertis
        {
            get { return name; }
            set { name=value; }
        }
        public int Agepropertis
        {
            get { return age; }
            set
            {
                if (value >=0)
                {
                    age=value;
                }
                else
                {
                    Console.WriteLine("Invald your age ");
                }
            }
        }
        public string GenderPropertis
        {
            get { return gender; }
            set { gender=value; }
        }


        public abstract void StatusSick();
        public abstract void StatusActive();
        public abstract void StatusSound();
        public abstract void StatusMissing();
        public abstract void StatusNotAvailable();
        public abstract void StatusUnavailable();
        public virtual void Eat()
        {
            Console.WriteLine("This is anmial is eat ");
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"ID :{id}");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Gender :{gender}");
        }
    }
    //الثديات 
    class Mammal : Animal
    {
        public string fulcolor { get; set; }

        public Mammal(int id, string name, int age, string gender, string fulcolor) : base(id, name, age, gender)
        {
            this.fulcolor=fulcolor;
        }
        public override void StatusActive()
        {
            Console.WriteLine($"The Status Mammal name: {base.NamePropertis} is An Active");
        }
        public override void StatusSick()
        {
            Console.WriteLine($"The Status Mammal name : {base.NamePropertis} is a sick ");
        }
        public override void StatusSound()
        {
            Console.WriteLine($"The Status Mammal name : {base.NamePropertis} is a sound");
        }
        public override void StatusMissing()
        {
            Console.WriteLine($"The Status Mammal name: {base.NamePropertis} is a Missing ");
        }
        public override void StatusNotAvailable()
        {
            Console.WriteLine($"The Status Mammal name: {base.NamePropertis} is  not available");
        }
        public override void StatusUnavailable()
        {
            Console.WriteLine($"The Status Mammal name: {base.NamePropertis} is an available");
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"The Mammal color is  {fulcolor} ");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"The  Status Mammal name {NamePropertis} is Eat  ");
        }

    }
    class Bird : Animal
    {
        public string FeatherColor { get; set; }//لون الجناح
        public double WingSpan { get; set; }//عرض الجناح
        public bool CanFly { get; set; }//القدرة على الطيران 
        public string DietType { get; set; }//نوع الغذاء
        public string Habitat { get; set; }//موطن الطاير
        public bool Migratory { get; set; }//الهجرة
        public double MaxFlightSpeed { get; set; }//السرعة القصوى لسرعة اللطيران 
        public string CommunicationMethod { get; set; }//طريقة التواصل 
        public int NumberOfEggs { get; set; }//عدد البيض 

        public Bird(int id, string name, int age, string gender, string color, double wingSpan, bool canFly, string dietTyp, string habitat, double maxFlightSpeed, string communicationMethod, int numberOfEggs) : base(id, name, age, gender)
        {
            FeatherColor=color;
            WingSpan=wingSpan;
            CanFly=canFly;
            DietType=dietTyp;
            Habitat=habitat;
            MaxFlightSpeed=maxFlightSpeed;
            CommunicationMethod=communicationMethod;
            NumberOfEggs=numberOfEggs;
        }

        public override void StatusActive()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is An Active");
        }
        public override void StatusSick()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is a sick ");
        }
        public override void StatusSound()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is a sound");
        }
        public override void StatusMissing()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is a Missing ");
        }
        public override void StatusNotAvailable()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is  not available");
        }
        public override void StatusUnavailable()
        {
            Console.WriteLine($"The Status Bird name: {base.NamePropertis} is an available");
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Feather Color: {FeatherColor}");
            Console.WriteLine($"Wing Span: {WingSpan} meters");
            Console.WriteLine($"Can Fly: {(CanFly ? "Yes" : "No")}");
            Console.WriteLine($"Diet Type: {DietType}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Migratory: {(Migratory ? "Yes" : "No")}");
            Console.WriteLine($"Max Flight Speed: {MaxFlightSpeed} km/h");
            Console.WriteLine($"Communication Method: {CommunicationMethod}");
            Console.WriteLine($"Number of Eggs: {NumberOfEggs}");

        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"The  Status Bird name {base.NamePropertis} is Eat  ");
        }
    }
    class ManagementSystem
    {
        private List<Mammal> mammals;
        private List<Bird> birds;
        public ManagementSystem()
        {
            mammals= new List<Mammal>();
            birds= new List<Bird>();
        }
        public void AddMammal()
        {
            Console.WriteLine("\n Enter Mammal ID :>>");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mammal Name :>>");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Mammal Age :>>");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mammal gender (Male/Famle):>>");
            string gender=Console.ReadLine();
            Console.WriteLine("Enter Mammal color :>>");
            string color=Console.ReadLine();

            Mammal mammal = new Mammal(id, name, age, gender, color);   
            mammals.Add(mammal);
            Console.WriteLine("Mammal Added Successfully ");
        }
        public void ViewMammal()
        {
            if (mammals.Count ==0)
            {
                Console.WriteLine("\n No Mammal in the zoo !!");
                return;
            }
            else
            {
                Console.WriteLine("\n List Mammal Animals ");
                foreach (var mammal in mammals)
                {
                    mammal.DisplayDetails();
                    Console.WriteLine(new string('=', 35));
                }
            }
        }

        public void SearchMammal()
        {
            Console.WriteLine("Enter the Mammal Name to search :>>");
            string name = Console.ReadLine();
            var found = mammals.Find(a => a.NamePropertis.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (found  != null)
            {
                Console.WriteLine("Mammal is found in the zoo");
                found.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Mammal Not Found in the zoo !!!");
            }
        }


        public void AddBirds()
        {
            Console.WriteLine("\n Enter Bird ID :>>");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bird Name :>>");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Bird Age :>>");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bird gender (Male/Famle):>>");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Bird color :>>");
            string color = Console.ReadLine();
            Console.WriteLine("Enter the Bird wing Span (e.g. 150.10) :>>");
            double wingSpan = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bird  can fly? (e.g. true/false) :>>");
            bool canFly =bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bird  DietTyp (e.g. Eat types) :>>");
            string dietTyp=Console.ReadLine();
            Console.WriteLine("Enter the Bird Habitat (e.g. Live Bird) :>>");
            string habitat=Console.ReadLine();
            Console.WriteLine("Enter the Bird Migratory travel (true/false) :>>");
            bool migratory = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bird (double) MaxFlightSpeed  (e.g. 100.12) :>>");
            double maxFlightSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bird  Communication Method or communication talk :>>");
            string communicationMethod=Console.ReadLine();
            Console.WriteLine("Enter the Bird  Number Of Eggs :>>");
            int numberOfEggs = int.Parse(Console.ReadLine());
            Bird bird1=new Bird(id, name, age, gender,color,wingSpan,canFly, dietTyp,habitat, maxFlightSpeed,communicationMethod, numberOfEggs);
            birds.Add(bird1);
            Console.WriteLine("Bird Added Successfully ");
        }
        public void ViewBird()
        {
            if (birds.Count ==0)
            {
                Console.WriteLine("\n No Bird in the box !!");
                return;
            }
            else
            {
                Console.WriteLine("\n List Bird Animals ");
                foreach (var bird in birds)
                {
                    bird.DisplayDetails();
                    Console.WriteLine(new string('=', 35));
                }
            }
        }

        public void SearchBird()
        {
            Console.WriteLine("Enter the Bird Name to search :>>");
            string name = Console.ReadLine();
            var found = birds.Find(a => a.NamePropertis.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (found  != null)
            {
                Console.WriteLine("Bird is found ");
                found.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Bird Not Found !!");
            }
        }
    }
}
