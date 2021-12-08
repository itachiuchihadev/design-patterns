namespace SingletonPattern
{
    public class SingletonClass
    {
        private static SingletonClass singletonInstance;
        public int i = 0;
        private SingletonClass(){

        }

        public static SingletonClass GetSingletonInstance()
        {
            if(singletonInstance == null){
                singletonInstance = new SingletonClass();
            }
            return singletonInstance;
        }
    }
}