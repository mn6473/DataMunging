There are two Windows console applications: Weather and Football. They operate on the weather.dat
and football.dat data files. For this program to work, THOSE DATA FILES MUST BE LOCATED IN A
DIRECTORY NAMED C:\DataMunging.

The codes assumes that the input data resides in text files. It could be 
modified to use other data storage types by subclassing the DataStore class and making that class
either an interface or an abstract class. 

The code does no error checking for data validity in the input files. It will simply blow up
if it cannot find the data file or if a file has some kind of unexpected format or an unexpected
character. The only oddball cases that are handled are what was in the orignal files, such as 
the weather file marking the high and low temperatures with an asterisk, or the the football
file have one line consisting of nothing but dases.

The Weather and Football programs could easily be made into a single application that uses
command line parameters or a configuration file to set up those program class's data. Even as 
it is currently written, none of the processing files have any knowledge of whether or not 
they are working on a Weather file or a Football file. The only things they care about are 
file name and the column numbers of the data they are operating on.
