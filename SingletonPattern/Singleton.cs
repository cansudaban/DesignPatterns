namespace NaiveSingletonPattern
{
    /// <summary>
    /// Sealed, sınıfların kalıtım işlemini engellemek için kullanılan bir anahtar kelimedir. 
    /// Sealed anahtar kelimesi bir sınıf için uygulanacak ise kalıtımı, bir üye için uygulanacak ise üyenin override edilmesini engellemektedir.
    /// </summary>
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void someBusinessLogic()
        {
            //..
        }
    }
}
