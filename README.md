# Mutation Testing using .Net and Stryker
## This is a test project for Back-End Test Technologies January 2024 Course @ SoftUni.
---
## Project Overview

This repository contains exercises focused on mutation testing, a critical aspect of ensuring code quality. 

## Project Structure

1. **ArrayTools Library**
    - This is a Class Library project named `ArrayTools`, which contains methods for array manipulations.

2. **Test Project**
    - A Test Project accompanies the `ArrayTools` library, with one test provided. Ensure the test passes to confirm the setup is correct.

## Getting Started

### Prerequisites

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
Stryker Playground
Visit the Stryker Playground to explore an interactive example. Experiment with creating additional tests to achieve a 100% mutation score.

Further Reading and Examples
Robo Coasters: Explore the Robo Coasters example for more insights into mutation testing with Stryker.
Robo Bar Example: Try the Robo Bar Example by following the tutorial. You'll need node.js and git to run this example.

## Contributing
Contributions are welcome! If you have any improvements or suggestions, feel free to open a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For any questions or suggestions, please reach out to the course instructor or open an issue in the repository.

