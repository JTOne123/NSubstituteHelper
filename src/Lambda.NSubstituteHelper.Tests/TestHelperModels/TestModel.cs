﻿using Unity = Microsoft.Practices.Unity;

namespace Lambda.NSubstituteHelper.Tests.TestHelperModels
{
	public class TestModel
	{
		public const string FirstDependencyName = "first";
		public const string SecondDependencyName = "second";

		public ISecondService SecondService2 { get; }
		public ITestService TestService2 { get; }
		public ITestService TestService { get; }
		public ISecondService SecondService { get; }

		public TestModel(ITestService testService, ISecondService secondService)
		{
			TestService = testService;
			SecondService = secondService;
		}

		public TestModel(ITestService testService)
		{
		}

		public TestModel(ITestService testService, ITestService testService2)
		{
			TestService = testService;
			TestService2 = testService2;
		}

		public TestModel([Unity.Dependency(FirstDependencyName)] ISecondService secondService, [Unity.Dependency(SecondDependencyName)]ISecondService secondService2)
		{
			SecondService = secondService;
			SecondService2 = secondService2;
		}

		public TestModel([Dependency] ISecondService secondService)
		{
			SecondService = secondService;
		}
	}
}
