# DesignPatternsC-

**DesignPatternsC-** is a simple C# console application that calculates the base area and volume of a rectangular box using dimensions entered by the user.

The project demonstrates fundamental C# programming concepts, including console input and output, variables, numeric data types, type conversion, and mathematical calculations.

## Features

- Accepts the length of a rectangular box.
- Accepts the width of a rectangular box.
- Accepts the height of a rectangular box.
- Calculates the area of the rectangular base.
- Calculates the volume of the box.
- Displays the results in the console.

## Requirements

- .NET SDK or a compatible C# development environment
- Visual Studio, Visual Studio Code, or another C#-compatible editor

## Project Structure

```text
DesignPatternsC-/
├── Software Design Program.cs
└── README.md
```

## How It Works

The program requests three dimensions from the user:

- **Length:** The length of the rectangular base.
- **Width:** The width of the rectangular base.
- **Height:** The height of the box.

It then calculates the base area and volume using these formulas:

**Base Area**

`Area = Length × Width`

**Volume**

`Volume = Length × Width × Height`

The program uses `Convert.ToDouble()` to convert the user's console input into numeric values.

## Example

For a box with a length of `5`, a width of `3`, and a height of `4`, the output is:

```text
Enter the length of the rectangular box: 5
Enter the width of the rectangular box: 3
Enter the height of the rectangular box: 4
The area of the base is: 15 square units.
The volume of the box is: 60 cubic units.
```

## How to Run

### Option 1: Using Visual Studio

1. Open Visual Studio.
2. Create or open a C# console application.
3. Add `Software Design Program.cs` to the project.
4. Build and run the application.
5. Enter the requested dimensions in the console.

### Option 2: Using the .NET CLI

If the source file is in a compatible .NET console project, run:

```bash
dotnet run
```

If you only have the `.cs` file, create a console project first, place the source file in that project, and then run the command.

## Concepts Demonstrated

- **Variables:** Stores the dimensions, base area, and volume.
- **Console Input:** Reads dimension values from the user.
- **Type Conversion:** Converts entered values into `double` values.
- **Arithmetic Operations:** Performs multiplication to calculate area and volume.
- **Console Output:** Displays the calculated results.

## Limitations

- The program does not validate non-numeric input.
- Negative dimensions are not rejected.
- The application handles a single box calculation per execution.
- Despite the repository name, the current implementation does not demonstrate a software design pattern.

## Author

**Ichiro Yamazaki**

## License

No license is currently specified in the repository. Check the repository for licensing information before redistributing or modifying the project.
