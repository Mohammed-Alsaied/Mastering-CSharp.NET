namespace Exceptions
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Delivered(delivery);
            }
            catch (AccidentException ex)
            {
                //Swallow -> empty catch
                //inform the user
                //log the exception
                //reset the value
                //Ducking(rethrowing)


                //Console.WriteLine($"There was an accident as: {ex.Message} preventing us from delivery");
                //delivery.DeliverySatues = DeliverySatues.UNKNOWN;
            }
            finally
            {

                //Console.WriteLine($"Deliver Fails due to: {ex.Message}");
                //delivery.DeliverySatues = DeliverySatues.UNKNOWN;
            }

        }

        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DeliverySatues = DeliverySatues.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damage during the loading process");
            }
            delivery.DeliverySatues = DeliverySatues.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("Intransing");
            throw new AccidentException("265 stret", "Accident!");
            delivery.DeliverySatues = DeliverySatues.INTRANSIT;
        }
        private void Delivered(Delivery delivery)
        {
            FakeIt("Out for Delivery");
            throw new InvalidAddressException($"{delivery.Address} is Invalid !");
            delivery.DeliverySatues = DeliverySatues.DELIVRED;
        }

        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
        }
    }
}
