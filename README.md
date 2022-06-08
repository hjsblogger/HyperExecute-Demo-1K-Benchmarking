Follow the below mentioned steps to trigger the test execution on LambdaTest Cloud or HyperExecute Grid:

## Download HyperExecute CLI

HyperExecute CLI is the CLI for interacting and running the tests on the HyperExecute Grid. The CLI provides a host of other useful features that accelerate test execution. In order to trigger tests using the CLI, you need to download the HyperExecute CLI binary corresponding to the platform (or OS) from where the tests are triggered:

Also, it is recommended to download the binary in the project's parent directory. Shown below is the location from where you can download the HyperExecute CLI binary:

* Mac: https://downloads.lambdatest.com/hyperexecute/darwin/hyperexecute
* Linux: https://downloads.lambdatest.com/hyperexecute/linux/hyperexecute
* Windows: https://downloads.lambdatest.com/hyperexecute/windows/hyperexecute.exe

## Configure Environment Variables

Before the tests are run, please set the following environment variables fom the terminal:

For macOS:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
export HYPEREXECUTE_PLATFORM='windows 10'
export HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```

For Linux:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
export HYPEREXECUTE_PLATFORM='windows 10'
export HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```

For Windows:

```bash
set LT_USERNAME=LT_USERNAME
set LT_ACCESS_KEY=LT_ACCESS_KEY
set HYPEREXECUTE_PLATFORM='windows 10'
set HYPEREXECUTE_WORKING_DIR='<full_path_project_directory>'
```

## Steps for test execution

* For running tests on Cloud Selenium Grid
Uncomment line number  10 and 11 of file — HyperTestDemo/CheckoutPage1Tests.cs
* For running tests on HyperExecute Grid
No change is required in the project

* Run the following command on the terminal to build the project:
```bash
dotnet build HyperTestDemos.sln -c Debug
```

* Run the following command on the terminal to run tests that are a part of the project:*
```bash
dotnet test HyperTestDemos.sln
```

## Benchmarking Information:

### LambdaTest Selenium Grid (25 Parallel Sessions)

<img alt="LambdaTest Grid Time Execution" src="https://user-images.githubusercontent.com/1688653/172609524-0547f6a8-ecd0-494b-ade5-3fbd26d42480.png">

### HyperExecute Grid (25 Parallel Sessions)
<img alt="LambdaTest HyperExecute Grid Time Execution" src="https://user-images.githubusercontent.com/1688653/172609550-7535a3f9-77be-4b03-a017-e28d2aa74123.png">

