using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        ResourceManager<string> resourceManager;

        [SetUp]
        public void Setup()
        {
            List<Resource<string>> resources = new List<Resource<string>>()
            {
                new Resource<string>()
                {
                    Value = "a"
                },
                new Resource<string>()
                {
                    Value = "b"
                },
                new Resource<string>()
                {
                    Value = "c"
                }
            };

            resourceManager = new ResourceManager<string>();
            resourceManager.Add(resources);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("a", resourceManager.GetNext().Value);
            Assert.AreEqual("b", resourceManager.GetNext().Value);
            Assert.AreEqual("c", resourceManager.GetNext().Value);
            Assert.AreEqual("a", resourceManager.GetNext().Value);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("a", resourceManager.GetNext().Value);
            Assert.AreEqual("b", resourceManager.GetNext().Value);
            Assert.AreEqual("c", resourceManager.GetNext().Value);
            Assert.AreEqual("a", resourceManager.GetNext().Value);

            resourceManager.Add("d");
            Assert.AreEqual("b", resourceManager.GetNext().Value);
            Assert.AreEqual("c", resourceManager.GetNext().Value);
            Assert.AreEqual("d", resourceManager.GetNext().Value);
            Assert.AreEqual("a", resourceManager.GetNext().Value);
        }
    }
}