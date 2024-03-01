// namespace Task1;
//
// public class SportCar : Car
// {
//     // - швидкість має бути в межах від 240 до 400
//     // - прохідність має бути в межах від 5 до 30
//
//     private int speed;
//     private int passability;
//     
//     public override required int Speed 
//     {
//         get => speed;
//         init
//         {
//             if (value is > 239 and < 401 )
//             {
//                 speed = value;
//             }
//             else
//             {
//                 Console.WriteLine("біда");
//             }
//         }
//     }
//     
//     public override required int Passability
//     {
//         get => passability;
//         init {
//             if (value is > 4 and < 31)
//             {
//                 passability = value;
//             }
//             else
//             {
//                 Console.WriteLine("біда");
//             }
//         }
//     }
//     
//     public SportCar() { }
//
//     public SportCar(int speed, int passability, string manufacturer)
//     {
//         Speed = speed;
//         Passability = passability;
//         base.Manufacturer = manufacturer;
//     }
// }