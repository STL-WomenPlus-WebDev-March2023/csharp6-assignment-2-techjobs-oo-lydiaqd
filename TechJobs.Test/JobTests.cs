using TechJobsOOAutoGraded6;
using System;
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id, job1.Id, "job1 is equal to job2");
            Assert.AreNotEqual(job1.Id, job2.Id, "job1 is not equal to job2");
            Assert.IsTrue(job1.Id < job2.Id, "job1 Id is less than job2");
            Assert.IsFalse(job1.Id > job2.Id, "job1 Id is not greater than job2");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester", "Testing Job Name");
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME", "Testing Employer Employer Name");
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert", "Testing Employer Employer Location");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control", "Testing Job Type");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence", "Testing Job Core Competency");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3.Id, job4.Id, "Jobs with different ids are not equal");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string ToStringValue = job3.ToString();
            Assert.IsTrue(ToStringValue.StartsWith(Environment.NewLine), "Testing starts with a new line");
            Assert.IsTrue(ToStringValue.EndsWith(Environment.NewLine), "Testing ends with a new line");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string ToStringValue = job3.ToString();
            Assert.IsTrue(ToStringValue.Contains("ID:  "), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Name: Product tester"), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Employer: ACME"), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Location: Desert"), "Testing ToString contains job location");
            Assert.IsTrue(ToStringValue.Contains("Position Type: Quality control"), "Testing ToString contains job type");
            Assert.IsTrue(ToStringValue.Contains("Core Competency: Persistence"), "Testing ToString contains core competency");
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string ToStringValue = job1.ToString();
            Console.Write(ToStringValue);
            Assert.IsTrue(ToStringValue.Contains("ID:  "), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Name: "), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Employer: "), "Testing ToString contains employer name");
            Assert.IsTrue(ToStringValue.Contains("Location: "), "Testing ToString contains job location");
            Assert.IsTrue(ToStringValue.Contains("Position Type: "), "Testing ToString contains job type");
            Assert.IsTrue(ToStringValue.Contains("Core Competency: "), "Testing ToString contains core competency");
        }
    }
}

