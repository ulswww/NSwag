namespace API
{
    static  class ClassFactory
    {
        static  IClient client;
        public static IClient Get()
        {
            if(client == null)
            {
                client = new ClientImpl("http://shambhala.dev.clolink.cn/");
            }

            return client;
        }
    }
}
