using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Windows.Threading;
class PerformanceCheck {
 static BindingFlags flags=BindingFlags.Instance|BindingFlags.NonPublic;
 static object Field(Overlay w,string name){return typeof(Overlay).GetField(name,flags).GetValue(w);}
 static void Assert(bool value,string label){if(!value)throw new Exception(label);Console.WriteLine("PASS "+label);}
 static Overlay Make(bool light,bool neon){
  Overlay.Folder=Path.GetFullPath("work/perf-tests/"+Guid.NewGuid().ToString("N"));Directory.CreateDirectory(Overlay.Folder);
  Overlay.DataFile=Path.Combine(Overlay.Folder,"session.json");
  File.WriteAllText(Path.Combine(Overlay.Folder,"preferences.json"),"{\"LightMode\":"+light.ToString().ToLowerInvariant()+"}");
  var w=new Overlay(true);
  var prefs=(AppPreferences)Field(w,"preferences");prefs.LightMode=light;
  var appearance=(AppearanceStore)Field(w,"appearance");foreach(var p in appearance.Profiles.Values)p.Neon=neon;
  typeof(Overlay).GetMethod("Build",flags).Invoke(w,null);
  w.Show();typeof(Overlay).GetMethod("SyncTrailTimer",flags).Invoke(w,null);return w;
 }
 [STAThread] static void Main(){
  System.Globalization.CultureInfo.CurrentCulture=System.Globalization.CultureInfo.InvariantCulture;
  var light=Make(true,true);
  Assert(((ICollection)Field(light,"visualClocks")).Count==0,"light mode creates no decorative animation clocks");
  Assert(((ICollection)Field(light,"textTrails")).Count==0,"light mode creates no animated text geometries");
  Assert(!((DispatcherTimer)Field(light,"trailTimer")).IsEnabled,"light mode leaves per-frame timer stopped while visible");light.Close();
  var full=Make(false,true);
  Assert(((ICollection)Field(full,"visualClocks")).Count>0,"full mode retains animations");
  Assert(((DispatcherTimer)Field(full,"trailTimer")).IsEnabled,"full mode animates visible neon trails");
  full.Hide();Assert(!((DispatcherTimer)Field(full,"trailTimer")).IsEnabled,"hidden full overlay stops trail timer");
  full.Show();Assert(((DispatcherTimer)Field(full,"trailTimer")).IsEnabled,"showing full overlay resumes trails");full.Close();
  var plain=Make(false,false);
  Assert(((ICollection)Field(plain,"textTrails")).Count==0,"neon disabled creates no invisible trail geometries");
  Assert(!((DispatcherTimer)Field(plain,"trailTimer")).IsEnabled,"neon disabled leaves trail timer stopped");plain.Close();
  Console.WriteLine("All performance checks passed.");
 }
}
