FundsLibrary Interview Test
===========================

Welcome to the FundsLibrary technical test!

This test is intended to be a simple test of coding ability. It should take up < 2 hours of your time.

## Test Details

This repository contains 2 binary files - file_0.bin and file_1.bin. The diff of the 2 files is as below:

	$ diff file_0.bin file_1.bin
	26,27c26,27
	< /ID [<41667C9D25F55FF22D2A7A93B949D904>
	< <36E081B23E919687F6F7198B39158ED0>]
	---
	> /ID [<5C81F950DBAC76449A067E3B0E8E5B07>
	> <B415FC2C79BB8CADC9C51AF05334780C>]

The task is to write a command line application that will determine if 2 files are equal. file_0.bin and file_1.bin should be considered equal. Other files (e.g. README.md, LICENCE.txt) should be considered unequal.

Future files that contain the pattern /\/ID \[<\.*\>\]/ should be considered equal.

Future files may be of any size.

## Technologies to be used

The solution should be a C# command line application.

You can download the community edition of Visual Studio from: [http://www.visualstudio.com/en-us/visual-studio-community-vs.aspx]
You could also use your favourite text editor and csc.exe on Windows, or Mono (http://www.mono-project.com/) on other operating systems.

Use of an alternative technology may have been negotiated during the telephone interview.

## How to submit your answer

* Fork this repository & send a pull request when you're done
* Download this repository [https://github.com/FundsLibrary/InterviewTest/archive/master.zip] and put the results somewhere public on the web (Dropbox, public Google Drive folder, public One Drive folder). Please note we cannot accept results via email, or FTP links.
