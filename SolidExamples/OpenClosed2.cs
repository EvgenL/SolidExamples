// IMovingMeans a = new Wheel();
// IMovingMeans b = new Thread();
//
// var array = new IMovingMeans[] { a, b };
// var moto = new Car(array);
//
// public class Car
// {
//     public Car(IMovingMeans[] movingMeansArray)
//     {
//         MovingMeans = movingMeansArray;
//     }
//
//     public IMovingMeans[] MovingMeans;
//
//     public void Drive()
//     {
//         MovingMeans[0].Drive();
//     }
// }
//
// public class Wheel : IMovingMeans
// {
//     public void Drive()
//     {
//     }
// }
//
// public class Thread : IMovingMeans
// {
//     public void Drive()
//     {
//     }
// }