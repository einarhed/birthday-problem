# Project Title

Birthday Problem Code Exercise

## Description

Simple programm that reads csv input that contains a list of persons name and birthday. The program checks if a person in the list has it's birthday today and if true it prints to the console happy birthday.

## Getting Started

### Dependencies

* .NET 8.0
* Make

### Installing

* Clone repo and run `make build` to build project and run tests
* Run `make run` to run the program

### Executing program

1. Build locally
   ```sh
   make build
   ```
2. Test locally
   ```sh
   make test
   ```
3. Run locally
   ```sh
   dotnet run [csv_filename]
   ```

## Extend the program

### Leap year day

Currently the program does not consider if a person birthday is on the 29th of February.

**Given** a person has a birthday on 29th of February

**When** today is 28th of February

**Then** that person should receive a Happy Birthday greeting

### Json input

Currently the program does not support reading Json input. Add a new adapter that supports reading a Json file as input.