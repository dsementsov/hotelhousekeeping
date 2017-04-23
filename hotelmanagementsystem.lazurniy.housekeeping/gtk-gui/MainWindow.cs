
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.FileChooserWidget pathOfASource;

	private global::Gtk.HBox hbox9;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Label label5;

	private global::Gtk.SpinButton spinTowels;

	private global::Gtk.Button button10;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label label7;

	private global::Gtk.SpinButton spinSheets;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label label9;

	private global::Gtk.SpinButton spinRobes;

	private global::Gtk.Button button14;

	private global::Gtk.VBox vbox8;

	private global::Gtk.Button button12;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.pathOfASource = new global::Gtk.FileChooserWidget(((global::Gtk.FileChooserAction)(0)));
		this.pathOfASource.Name = "pathOfASource";
		this.hbox2.Add(this.pathOfASource);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.pathOfASource]));
		w1.Position = 0;
		w1.Padding = ((uint)(15));
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w2.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		this.hbox9.BorderWidth = ((uint)(5));
		// Container child hbox9.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.WidthRequest = 150;
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Полотенца");
		this.vbox6.Add(this.label5);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label5]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.spinTowels = new global::Gtk.SpinButton(1, 14, 1);
		this.spinTowels.CanDefault = true;
		this.spinTowels.CanFocus = true;
		this.spinTowels.Name = "spinTowels";
		this.spinTowels.Adjustment.PageIncrement = 10;
		this.spinTowels.ClimbRate = 1;
		this.spinTowels.Numeric = true;
		this.spinTowels.Value = 1;
		this.vbox6.Add(this.spinTowels);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.spinTowels]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.button10 = new global::Gtk.Button();
		this.button10.HeightRequest = 38;
		this.button10.CanFocus = true;
		this.button10.Name = "button10";
		this.button10.UseUnderline = true;
		this.button10.Label = global::Mono.Unix.Catalog.GetString("Выход");
		this.vbox6.Add(this.button10);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.button10]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.hbox9.Add(this.vbox6);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox6]));
		w6.Position = 0;
		// Container child hbox9.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.WidthRequest = 150;
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Простыни");
		this.vbox4.Add(this.label7);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label7]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.spinSheets = new global::Gtk.SpinButton(1, 14, 1);
		this.spinSheets.CanDefault = true;
		this.spinSheets.CanFocus = true;
		this.spinSheets.Name = "spinSheets";
		this.spinSheets.Adjustment.PageIncrement = 10;
		this.spinSheets.ClimbRate = 1;
		this.spinSheets.Numeric = true;
		this.spinSheets.Value = 1;
		this.vbox4.Add(this.spinSheets);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.spinSheets]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox9.Add(this.vbox4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox4]));
		w9.Position = 1;
		// Container child hbox9.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.WidthRequest = 150;
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Халаты");
		this.vbox2.Add(this.label9);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label9]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.spinRobes = new global::Gtk.SpinButton(1, 14, 1);
		this.spinRobes.CanDefault = true;
		this.spinRobes.CanFocus = true;
		this.spinRobes.Name = "spinRobes";
		this.spinRobes.Adjustment.PageIncrement = 10;
		this.spinRobes.ClimbRate = 1;
		this.spinRobes.Numeric = true;
		this.spinRobes.Value = 1;
		this.vbox2.Add(this.spinRobes);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.spinRobes]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button14 = new global::Gtk.Button();
		this.button14.HeightRequest = 38;
		this.button14.CanFocus = true;
		this.button14.Name = "button14";
		this.button14.UseUnderline = true;
		this.button14.Label = global::Mono.Unix.Catalog.GetString("Сохранить настройки");
		this.vbox2.Add(this.button14);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.button14]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.hbox9.Add(this.vbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox2]));
		w13.Position = 2;
		// Container child hbox9.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.WidthRequest = 100;
		this.vbox8.HeightRequest = 100;
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.button12 = new global::Gtk.Button();
		this.button12.CanFocus = true;
		this.button12.Name = "button12";
		this.button12.UseUnderline = true;
		this.button12.Label = global::Mono.Unix.Catalog.GetString("Готово");
		this.vbox8.Add(this.button12);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.button12]));
		w14.Position = 0;
		w14.Padding = ((uint)(4));
		this.hbox9.Add(this.vbox8);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox8]));
		w15.Position = 3;
		w15.Expand = false;
		w15.Fill = false;
		this.vbox1.Add(this.hbox9);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox9]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		w16.Padding = ((uint)(15));
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 946;
		this.DefaultHeight = 464;
		this.spinTowels.HasDefault = true;
		this.spinSheets.HasDefault = true;
		this.spinRobes.HasDefault = true;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.DefaultActivated += new global::System.EventHandler(this.OnDefaultActivated);
		this.pathOfASource.SelectionChanged += new global::System.EventHandler(this.OnPathChanged);
		this.button10.Clicked += new global::System.EventHandler(this.OnExitClicked);
		this.button14.Clicked += new global::System.EventHandler(this.OnSaveClicked);
		this.button12.Clicked += new global::System.EventHandler(this.OnDoneClicked);
	}
}