namespace ClassLibrary1
{
    public class ResourceManager<T>
    {
        private List<Resource<T>> Resources = new List<Resource<T>>();
        private int index = 0;

        public Resource<T> GetNext()
        {
            Resource<T> result = Resources[index++];
            index = index % Resources.Count;
            return result;
        }

        public void Add(T value)
        {
            Resource<T> resource = new Resource<T> { Value = value };

            Resources.Add(resource);
        }

        public void Add(Resource<T> resource)
        {
            Resources.Add(resource);
        }

        public void Add(List<Resource<T>> resources)
        {
            foreach (Resource<T> resource in resources)
            {
                Add(resource);
            }
        }
    }
}