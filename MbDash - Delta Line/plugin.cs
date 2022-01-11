
//target (visible) width of the widget
int targetWidth = 800;
// actual widget width
int maxWidth = 1200;

// width of the time block
int timeBlockWidth = 120;

// plus/minus time bar size
int progressBarSize = targetWidth / 2;

// time progress size (one time bar) according to target widget width
int timeProgressSize = progressBarSize - timeBlockWidth / 2;

// target width
value.AddProperty("MbDash_DeltaTime.Width", value.GetType(), targetWidth);
// max width
value.AddProperty("MbDash_DeltaTime.WidthMax", value.GetType(), maxWidth);

// X seconds for full time bar
value.AddProperty("MbDash_DeltaTime.Seconds", value.GetType(), 1);

// set length of time block "progress" for one time bar
value.AddProperty("MbDash_DeltaTime.TimeSize", 
   value.GetType(), timeProgressSize);

// formula: total width /2 - time block width / 2
value.AddProperty("MbDash_DeltaTime.TimePaddingCenter", 
   value.GetType(), maxWidth  / 2 - timeBlockWidth / 2);

// set most left position for time block
value.AddProperty("MbDash_DeltaTime.TimePaddingLeft", 
   value.GetType(), (maxWidth - targetWidth)/2);

// set most right position for time block
value.AddProperty("MbDash_DeltaTime.TimePaddingRight", 
   value.GetType(), maxWidth - (maxWidth - targetWidth)/2 - timeBlockWidth);

// set size of time bar
value.AddProperty("MbDash_DeltaTime.ProgressSize", 
   value.GetType(), progressBarSize);
   
// set center position
value.AddProperty("MbDash_DeltaTime.ProgressPlusPosition", 
   value.GetType(), (maxWidth - targetWidth)/2);
   
return 1;
