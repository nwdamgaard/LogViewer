# LogViewer
I made this tool to view MS41 logs because I'm too cheap to buy MegaLogViewer and RomRaiderLogViewer kinda stinks.

You can open any CSV file with this, but the program is expecting an equal number of columns in every row, and the first row should have the names of the columns.

If you have any issues or feature requests feel free to submit an issue or pull request.

## Features:
- quickly graph log data so you can spend more time tuning than fighting with the software
- allows you to choose any logged variable as the X and Y axis
- graph multiple variables at once with different scales
- choose between a line graph and a point graph

## Planned features:
- allow you to load a second log to overlay on the graph, useful for VANOS tuning
- save settings for certain graphs, for example if you had an RPM vs. Load you wouldn't want a line graph, so I want to be able to set it so if you choose RPM vs Load it'll automatically switch to a point graph
- choose a subset of points to show on the graph, for example if you're only interested in the time between 20,000-50,000ms you should be able to select that range and only plot the points between those on your RPM vs Load graph. Useful if you start the log on the side of the road, do a WOT pull, and only care about the data during the pull.
