using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Empty test to verify references
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //Test to ensure a unique job Id for every job class created
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.AreNotEqual(test_job1.Id, test_job2.Id);
        }
        //Test
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME", test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
        }
        //Test the job.cs Equals method
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(test_job1.Equals(test_job2));
        }
        //Test the job.cs ToString method begins and ends with a blank line
        [TestMethod]
        public void TestToString1()
        {
            Job test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual($"\nID: {test_job1.Id}\nName:  {test_job1.Name}\nEmployer:  {test_job1.EmployerName.Value}\nLocation:  {test_job1.EmployerLocation.Value}\nPosition Type:  {test_job1.JobType.Value}\nCore Competency:  {test_job1.JobCoreCompetency.Value}\n", test_job1.ToString());
        }
        //Test the job.cs ToString method that if a field is left empty method adds "Data not available" after the label
        [TestMethod]
        public void TestToString2()
        {
            Job test_job1 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual($"\nID: {test_job1.Id}\nName:  Data not available\nEmployer:  Data not available\nLocation:  Data not available\nPosition Type:  Data not available\nCore Competency:  Data not available\n", test_job1.ToString());
        }
    }
}
