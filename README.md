# Mutation Tests with .Net and Stryker
[![C#](https://img.shields.io/badge/Made%20with-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91.svg)](https://dotnet.microsoft.com/)
[![NUnit](https://img.shields.io/badge/tested%20with-NUnit-22B2B0.svg)](https://nunit.org/)
[![Stryker](https://img.shields.io/badge/mutation%20tested%20with-Stryker-4E4E4E.svg)](https://stryker-mutator.io/)

### This is a test project for **Back-End Test Technologies** January 2024 Course @ SoftUni.
---

## Prerequisites

- .NET Core SDK 3.1 or higher
- Visual Studio 2019 or later / Visual Studio Code

## Mutation Testing with Stryker

1. **Installing Stryker**:

Install Stryker using the Package Manager Console with the following command

```bash
dotnet tool install -g dotnet-stryker
```

2. **Running Stryker**:

Execute Stryker to perform mutation testing on your project:

```bash
dotnet stryker
```
## Analyzing the Report
After running Stryker, observe the generated report. The report will show the mutation score, which indicates the effectiveness of your tests. Aim to achieve a 100% mutation score by adding more tests.

## Exploring Stryker Further
- [Stryker Playground](https://stryker-mutator.io/stryker-playground)
- Visit the Stryker Playground to explore an interactive example. Experiment with creating additional tests to achieve a 100% mutation score.

## Further Reading and Examples
- [Robo Coasters](https://stryker-mutator.io/robo-coasters-example): Explore the Robo Coasters example for more insights into mutation testing with Stryker.
- [Robo Bar Example](https://stryker-mutator.io/docs/General/example): Try the Robo Bar Example by following the tutorial. You'll need node.js and git to run this example.

## License
This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or suggestions, please reach out to the course instructor or open an issue in the repository.

---
### Happy Testing! 🚀
