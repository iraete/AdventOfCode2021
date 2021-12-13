# AdventOfCode2021

This project contains my solutions to the Advent of Code 2021 code challenges,
contained as a .NET Core console CLI application.

## Installation

Clone the repository. In the repository directory, run `dotnet restore` and `dotnet build`.

## Running the tests

This project also contains a test suite to run the given test inputs from the AoC website and more. To run them, run `dotnet test`.

## Usage

In the `/src` folder:

```bash
dotnet run -- day problem [input_file] [-o output_directory]
```

Example: `dotnet run -- 1 1 ./inputfile.in -o ../output`

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
