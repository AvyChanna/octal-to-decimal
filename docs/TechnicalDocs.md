# Octal To Decimal Converter

This project converts given octal number to its decimal equivalent and helps the user visualise the whole process creatively.

It is made to teach kids understand what actually happens when numbers are converted from octal to decimal. On the other hand it can also be used by professionals for converting large octal numbers to decimal as it has a large range.

## Process

This project is mainly composed of 3 components:-

1. Input obtaining and validation
2. Processing input to obtain a the correct output string.
3. Creative visualisation of the process for better understanding of the process.

### Algorithm Used

The essence of the algorithmused is as follows-

For an octal number A<sub>n</sub>...A<sub>2</sub>A<sub>1</sub>A<sub>0.</sub>A<sub>-1</sub>A<sub>-2</sub>....A<sub>-m</sub> , its decimal equivalent is  A<sub>n</sub>*8<sup>n</sup>+....+A<sub>2</sub>*8<sup>2</sup>+A<sub>1</sub>*8<sup>1</sup>+A<sub>0</sub>*8<sup>0</sup>.A<sub>-1</sub>*8<sup>-1</sup>+A<sub>-2</sub>*8<sup>-2</sup>+....+A<sub>-m</sub>*8<sup>-m</sup>
The same can be seen in module *Convert.vb*. **The limit of length of number input is 32767 digits inclusive of decimal point.**

### Visualization

A separate module named *Graphics.vb* handles all the formatting of text. It handles all cases - is the character zero, is there decimal, is the result negative ... and so on.

### Validation

Validation is done in *ValidationFunctionModule.vb*

It checks for

- Empty Strings
- Invalid Characters
- Invalid Configuration of Allowed Characters
- Atleast one Octal Digit OR a +/- OR a Decimal Dot

## Functions and Subroutines

### Module ValidationFunctionModule

1. ValidateInput(string) = Boolean

    **Task** - Takes an Input string and checks if it is a valid input (octal number).

    **Input** - String InputOctalNumber

    **Returns** - Boolean

### Module Graphics

1. GenerateExplanation(string, string) = String

    **Task** - Takes original input and result, and generate rtf format string containing all visuals.

    **Input** - String InputOctalNumber, String Result

    **Returns** - String RtfFormatText

### Module Convert

1. ConvertDec(string) = String

    **Task** - Takes original input finds final result in decimal.

    **Input** - String InputOctalNumber

    **Returns** - String Result

2. SupportFunction(String, Integer, Char) = String

    **Task** - Takes a digit as char, position of result string to modify, and generates contribution of that digit in result.

    **Input** - String Newnumber, Integer Position, Char Digit

    **Returns** - String PartialResult

### Main Form Class Event Handlers

Form1_Load - Centres text in textbox and moves cursor to InputOctal Textbox.

ExitButton_Click - Exits the Application.

ResetButton_Click - Resets all the textbox inputs/outputs.

FileInput_Click - Opens FileInputDialog and reads the contents to InputOctal textbox and starts conversion.
**File contents are trimmed of whitespaces in start and end**.

FileOutput_Click - Opens FileOutputDialog and writes the result to file.

ShowVisuals_CheckedChange - Handles the cases when user toggles explanation onn/off.

OkButton_Click - Initiates conversion and generates explanation if needed.

## GUI Features

InputOctal - Take input as octal number from user

OutputDecimal - Provides output as decimal to user

ShowVisuals - Checks if user wants Visuals or not

Explanation - Gives visualization of whole process

ResetButton - Clears InputOctal, OutputDecimal, Explanation

OkButton - Initiates Conversion

ExitButton - Exits the application

FileInput - Opens FileInputDialog to open a file to read from

FileOutput - Opens FileOutputDialog to open a file to write to

FileinputDialog - GUI for selection of location of input file

FileOutputDialog - GUI for selection of location of output file
