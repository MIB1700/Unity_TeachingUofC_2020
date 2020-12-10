{
	"patcher" : 	{
		"fileversion" : 1,
		"appversion" : 		{
			"major" : 7,
			"minor" : 3,
			"revision" : 4,
			"architecture" : "x86",
			"modernui" : 1
		}
,
		"rect" : [ 100.0, 100.0, 1076.0, 480.0 ],
		"bglocked" : 0,
		"openinpresentation" : 0,
		"default_fontsize" : 12.0,
		"default_fontface" : 0,
		"default_fontname" : "Arial",
		"gridonopen" : 1,
		"gridsize" : [ 15.0, 15.0 ],
		"gridsnaponopen" : 1,
		"objectsnaponopen" : 1,
		"statusbarvisible" : 2,
		"toolbarvisible" : 1,
		"lefttoolbarpinned" : 0,
		"toptoolbarpinned" : 0,
		"righttoolbarpinned" : 0,
		"bottomtoolbarpinned" : 0,
		"toolbars_unpinned_last_save" : 0,
		"tallnewobj" : 0,
		"boxanimatetime" : 200,
		"enablehscroll" : 1,
		"enablevscroll" : 1,
		"devicewidth" : 0.0,
		"description" : "",
		"digest" : "",
		"tags" : "",
		"style" : "",
		"subpatcher_template" : "",
		"boxes" : [ 			{
				"box" : 				{
					"id" : "obj-4",
					"linecount" : 5,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 330.0, 401.0, 147.0, 76.0 ],
					"style" : "",
					"text" : "-3.454625 10.020375 2.3375 0.01475 -8.319625 -3.80625 7.8135 -1.354125 3.5205 3.493375"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-5",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 343.0, 360.0, 55.0, 22.0 ],
					"style" : "",
					"text" : "MRdelta"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-3",
					"linecount" : 3,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 543.0, 401.0, 147.0, 49.0 ],
					"style" : "",
					"text" : "5 3 23 -6 -11 -26 -30 0 0 -16 -1 -12 -6 28 4 -5 23 1 30 32"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-1",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 556.0, 360.0, 55.0, 22.0 ],
					"style" : "",
					"text" : "MRdelta"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-38",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 967.0, 306.0, 41.5, 22.0 ],
					"style" : "",
					"text" : "+ 20."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-37",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"patching_rect" : [ 925.0, 268.0, 61.0, 22.0 ],
					"style" : "",
					"text" : "gate 2 1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-36",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 925.0, 221.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "+ 1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-35",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 925.0, 189.0, 46.0, 22.0 ],
					"style" : "",
					"text" : "decide"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-34",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 925.0, 306.0, 34.0, 22.0 ],
					"style" : "",
					"text" : "+ 20"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-33",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 896.0, 158.0, 75.0, 22.0 ],
					"style" : "",
					"text" : "random 100"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-32",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 813.0, 189.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "+ 5"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-31",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 813.0, 158.0, 68.0, 22.0 ],
					"style" : "",
					"text" : "random 25"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-27",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 651.0, 311.0, 149.0, 22.0 ],
					"style" : "",
					"text" : "21 79 40 10"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-28",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 780.0, 125.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-29",
					"maxclass" : "newobj",
					"numinlets" : 4,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 780.0, 282.0, 118.0, 22.0 ],
					"style" : "",
					"text" : "MRrandL 10 5 10"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-30",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 732.0, 92.0, 150.0, 20.0 ],
					"style" : "",
					"text" : "set input dynamically"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-23",
					"linecount" : 3,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 427.0, 247.0, 148.0, 49.0 ],
					"style" : "",
					"text" : "66 68 73 42 51 46 40 70 68 51 48 42 50 74 63 45 64 64 72 73"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-24",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 556.0, 170.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-25",
					"maxclass" : "newobj",
					"numinlets" : 4,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 556.0, 208.0, 109.0, 22.0 ],
					"style" : "",
					"text" : "MRrandL 20 40 77"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-26",
					"linecount" : 3,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 493.0, 117.0, 150.0, 47.0 ],
					"style" : "",
					"text" : "automatically convert between int and float output"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-19",
					"linecount" : 5,
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 214.0, 247.0, 148.0, 76.0 ],
					"style" : "",
					"text" : "-0.863125 8.97 9.055875 3.498125 1.488375 1.862625 7.790875 4.855875 9.011125 3.47225"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-20",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 343.0, 170.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-21",
					"maxclass" : "newobj",
					"numinlets" : 4,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 343.0, 208.0, 117.0, 22.0 ],
					"style" : "",
					"text" : "MRrandL 10 -2 10.5"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-22",
					"linecount" : 5,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 229.0, 132.0, 150.0, 74.0 ],
					"style" : "",
					"text" : "use arguments to set:\n\nlength (int)\nmin (int or float)\nmax (int or float)"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-16",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 7.0, 247.0, 148.0, 22.0 ],
					"style" : "",
					"text" : "4 9 6"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-14",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 136.0, 170.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-12",
					"maxclass" : "newobj",
					"numinlets" : 4,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 136.0, 208.0, 60.0, 22.0 ],
					"style" : "",
					"text" : "MRrandL"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-18",
					"linecount" : 7,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 22.0, 132.0, 150.0, 100.0 ],
					"style" : "",
					"text" : "create random lists.\n\ndefault: \n\nlength = 3\nmin = 1\nmax = 10"
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 1 ],
					"source" : [ "obj-1", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 1 ],
					"source" : [ "obj-12", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-12", 0 ],
					"source" : [ "obj-14", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"source" : [ "obj-20", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-19", 1 ],
					"order" : 1,
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-5", 0 ],
					"order" : 0,
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-25", 0 ],
					"source" : [ "obj-24", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 0 ],
					"order" : 0,
					"source" : [ "obj-25", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-23", 1 ],
					"order" : 1,
					"source" : [ "obj-25", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 0 ],
					"order" : 2,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"order" : 1,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-33", 0 ],
					"order" : 0,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 1 ],
					"source" : [ "obj-29", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-32", 0 ],
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 1 ],
					"source" : [ "obj-32", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-35", 0 ],
					"order" : 1,
					"source" : [ "obj-33", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-37", 1 ],
					"order" : 0,
					"source" : [ "obj-33", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 3 ],
					"source" : [ "obj-34", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-36", 0 ],
					"source" : [ "obj-35", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-37", 0 ],
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-34", 0 ],
					"source" : [ "obj-37", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-38", 0 ],
					"source" : [ "obj-37", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 3 ],
					"source" : [ "obj-38", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-4", 1 ],
					"source" : [ "obj-5", 0 ]
				}

			}
 ],
		"parameters" : 		{
			"obj-5::obj-9::obj-12::obj-28" : [ "textbutton[23]", "textbutton", 0 ],
			"obj-29::obj-5::obj-25::obj-28" : [ "textbutton[8]", "textbutton", 0 ],
			"obj-12::obj-5::obj-25::obj-28" : [ "textbutton[9]", "textbutton", 0 ],
			"obj-25::obj-3::obj-25::obj-28" : [ "textbutton[3]", "textbutton", 0 ],
			"obj-21::obj-26::obj-12::obj-28" : [ "textbutton[20]", "textbutton", 0 ],
			"obj-29::obj-3::obj-25::obj-28" : [ "textbutton[15]", "textbutton", 0 ],
			"obj-12::obj-25::obj-28" : [ "textbutton[18]", "textbutton", 0 ],
			"obj-21::obj-3::obj-25::obj-28" : [ "textbutton[7]", "textbutton", 0 ],
			"obj-5::obj-10::obj-25::obj-28" : [ "textbutton[11]", "textbutton", 0 ],
			"obj-1::obj-10::obj-25::obj-28" : [ "textbutton[22]", "textbutton", 0 ],
			"obj-5::obj-3::obj-28" : [ "textbutton[24]", "textbutton", 0 ],
			"obj-25::obj-25::obj-28" : [ "textbutton[1]", "textbutton", 0 ],
			"obj-21::obj-5::obj-25::obj-28" : [ "textbutton[6]", "textbutton", 0 ],
			"obj-12::obj-26::obj-12::obj-28" : [ "textbutton[21]", "textbutton", 0 ],
			"obj-21::obj-25::obj-28" : [ "textbutton[5]", "textbutton", 0 ],
			"obj-1::obj-9::obj-12::obj-28" : [ "textbutton[16]", "textbutton", 0 ],
			"obj-29::obj-26::obj-12::obj-28" : [ "textbutton[12]", "textbutton", 0 ],
			"obj-25::obj-5::obj-25::obj-28" : [ "textbutton[2]", "textbutton", 0 ],
			"obj-1::obj-3::obj-28" : [ "textbutton[17]", "textbutton", 0 ],
			"obj-29::obj-25::obj-28" : [ "textbutton[14]", "textbutton", 0 ],
			"obj-25::obj-26::obj-12::obj-28" : [ "textbutton[10]", "textbutton", 0 ],
			"obj-12::obj-3::obj-25::obj-28" : [ "textbutton[19]", "textbutton", 0 ]
		}
,
		"dependency_cache" : [ 			{
				"name" : "MRrandL.maxpat",
				"bootpath" : "~/Documents/Music/Max/Max7/MRToolbox (all)/inProgress/MRrandL",
				"patcherrelativepath" : ".",
				"type" : "JSON",
				"implicit" : 1
			}
, 			{
				"name" : "MRzlAutoSize.maxpat",
				"bootpath" : "~/Documents/Music/Max/Max7/MRToolbox (all)/inProgress/MRzlAutoSize",
				"patcherrelativepath" : "../MRzlAutoSize",
				"type" : "JSON",
				"implicit" : 1
			}
, 			{
				"name" : "MRabstractionPrintBP.maxpat",
				"bootpath" : "~/Documents/Music/Max/Max7/100Days/lib/MRabstractionPrint",
				"patcherrelativepath" : "../../../100Days/lib/MRabstractionPrint",
				"type" : "JSON",
				"implicit" : 1
			}
, 			{
				"name" : "MRtype.maxpat",
				"bootpath" : "~/Documents/Music/Max/Max7/MRToolbox (all)/inProgress/MRtype",
				"patcherrelativepath" : "../MRtype",
				"type" : "JSON",
				"implicit" : 1
			}
, 			{
				"name" : "MRdelta.maxpat",
				"bootpath" : "~/Documents/Music/Max/Max7/MRToolbox (all)/inProgress/MRdelta",
				"patcherrelativepath" : "../MRdelta",
				"type" : "JSON",
				"implicit" : 1
			}
 ],
		"autosave" : 0
	}

}
