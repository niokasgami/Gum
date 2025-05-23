//Code for Controls/TextBox (Container)
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using GameUiSamples.Components;

using RenderingLibrary.Graphics;

using System.Linq;

using MonoGameGum.GueDeriving;
namespace GameUiSamples.Components
{
    public partial class TextBoxRuntime:ContainerRuntime
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        public static void RegisterRuntimeType()
        {
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TextBox", typeof(TextBoxRuntime));
        }
        public MonoGameGum.Forms.Controls.TextBox FormsControl => FormsControlAsObject as MonoGameGum.Forms.Controls.TextBox;
        public enum TextBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected,
        }
        public enum LineModeCategory
        {
            Single,
            Multi,
        }

        public TextBoxCategory TextBoxCategoryState
        {
            set
            {
                if(Categories.ContainsKey("TextBoxCategory"))
                {
                    var category = Categories["TextBoxCategory"];
                    var state = category.States.Find(item => item.Name == value.ToString());
                    this.ApplyState(state);
                }
                else
                {
                    var category = ((Gum.DataTypes.ElementSave)this.Tag).Categories.FirstOrDefault(item => item.Name == "TextBoxCategory");
                    var state = category.States.Find(item => item.Name == value.ToString());
                    this.ApplyState(state);
                }
            }
        }

        public LineModeCategory LineModeCategoryState
        {
            set
            {
                if(Categories.ContainsKey("LineModeCategory"))
                {
                    var category = Categories["LineModeCategory"];
                    var state = category.States.Find(item => item.Name == value.ToString());
                    this.ApplyState(state);
                }
                else
                {
                    var category = ((Gum.DataTypes.ElementSave)this.Tag).Categories.FirstOrDefault(item => item.Name == "LineModeCategory");
                    var state = category.States.Find(item => item.Name == value.ToString());
                    this.ApplyState(state);
                }
            }
        }
        public NineSliceRuntime Background { get; protected set; }
        public NineSliceRuntime SelectionInstance { get; protected set; }
        public TextRuntime TextInstance { get; protected set; }
        public TextRuntime PlaceholderTextInstance { get; protected set; }
        public NineSliceRuntime FocusedIndicator { get; protected set; }
        public SpriteRuntime CaretInstance { get; protected set; }
        public ContainerRuntime MinSizeContainer { get; protected set; }

        public string PlaceholderText
        {
            get => PlaceholderTextInstance.Text;
            set => PlaceholderTextInstance.Text = value;
        }

        public TextBoxRuntime(bool fullInstantiation = true, bool tryCreateFormsObject = true)
        {


        }
        public override void AfterFullCreation()
        {
            if (FormsControl == null)
            {
                FormsControlAsObject = new MonoGameGum.Forms.Controls.TextBox(this);
            }
            Background = this.GetGraphicalUiElementByName("Background") as NineSliceRuntime;
            SelectionInstance = this.GetGraphicalUiElementByName("SelectionInstance") as NineSliceRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as TextRuntime;
            PlaceholderTextInstance = this.GetGraphicalUiElementByName("PlaceholderTextInstance") as TextRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as NineSliceRuntime;
            CaretInstance = this.GetGraphicalUiElementByName("CaretInstance") as SpriteRuntime;
            MinSizeContainer = this.GetGraphicalUiElementByName("MinSizeContainer") as ContainerRuntime;
            CustomInitialize();
        }
        //Not assigning variables because Object Instantiation Type is set to By Name rather than Fully In Code
        partial void CustomInitialize();
    }
}
