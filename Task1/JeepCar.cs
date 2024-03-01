// namespace Task1;
//
// public class JeepCar : Car
// {
//     // - швидкість має бути в межах від 150 до 240
//     // - прохідність має бути в межах від 60 до 100
//     
//     private int speed;
//     private int passability;
//     
//     public override required int Speed 
//     {
//         get => speed;
//         init
//         {
//             if (value is > 149 and < 241 )
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
//             if (value is > 59 and < 101)
//             {
//                 passability = value;
//             }
//             else
//             {
//                 Console.WriteLine("біда");
//             }
//         }
//     }
// }