# LogViewer
I made this tool to view MS41 logs because I'm too cheap to buy MegaLogViewer and RomRaiderLogViewer kinda stinks.

You can open any CSV file with this, but the program is expecting an equal number of columns in every row, and the first row should have the names of the columns.

If you have any issues or feature requests feel free to submit an issue or pull request.

## Features:
- quickly graph log data so you can spend more time tuning and less time fighting with software
  - save graph configurations to quickly call up the exact graphs you need
- set X and Y axis to any two log variables
- overlay multiple graphs

## Planned features:
- allow you to load a second log file to overlay on the graph, useful for VANOS tuning
- Data filters. For example only show data where throttle position is greater than 50%, or only show data where load is 500-1000 mg/stk.
- Enter formulas to calculate a new variable based on existing data. Can be used to calculate things like volumetric efficiency and intake manifold pressure.

## Install:
- Download the latest release from [here](https://github.com/nwdamgaard/LogViewer/releases).
- Extract the archive and run the LogViewer executable. Requires .NET framework.
