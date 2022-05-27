This Windows console application assumes that the input data resides in text files. It could be 
modified to use other data storage types by subclassing the DataStore class and making that class
either an interface or an abstract class. 

The code does no error checking for data validity in the input files.

The Weather and Football programs could easily be made into a single application that uses
command line parameters or a configuration file to set up those program class's data. Even as 
it is currently written, none of the processing files have any knowledge of whether or not 
they are working on a Weather file or a Football file. The only things they care about are 
file name and the column numbers of the data they are operating on.