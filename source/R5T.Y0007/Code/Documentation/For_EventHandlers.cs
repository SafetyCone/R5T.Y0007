using System;

using R5T.T0156;


namespace R5T.Y0007
{
	public static partial class Documentation
	{
        /// <summary>
        /// Documentation for the Microsoft.AspNetCore.Components.EventHandlerAttribute concept.
        /// </summary>
        [DocumentationMarker]
        public static partial class For_EventHandlers
        {
            /// <summary>
            /// <value>Microsoft.AspNetCore.Components.EventHandlerAttribute</value>
            /// </summary>
            public static readonly object EventHandlerAttributeType_NamespacedTypeName;

            /// <summary>
            /// This is the MS Documentation for the <inheritdoc cref="EventHandlerAttributeType_NamespacedTypeName" path="descendant::value"/> type.
            /// <link><see href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.eventhandlerattribute"/></link>
            /// </summary>
            public static readonly object EventHandlerAttributeType_MSDocsLink;

            /// <summary>
            /// Shows how to create a static EventHandlers class with multiple <inheritdoc cref="EventHandlerAttributeType_NamespacedTypeName" path="descendant::value"/> attributes,
            /// one for each custom DOM event.
            /// <link><see href="https://learn.microsoft.com/en-us/aspnet/core/blazor/components/event-handling#general-configuration"/></link>
            /// </summary>
            public static readonly object CustomEventExample_MSDocsLink;

            /// <summary>
            /// The static class that serves as the hosting type for event handler attributes must be a static class, named <value>EventHandlers</value>.
            /// </summary>
            public static readonly object EventHandlersRequiredStaticClassName;

            /// <summary>
            /// The type that hosts the various <inheritdoc cref="EventHandlerAttributeType_NamespacedTypeName" path="descendant::value"/> attributes:
            /// <list type="bullet">
            /// <item>Must be a top-level (non-nested) class.</item>
            /// <item>Must be a public class.</item>
            /// <item>Must be called <inheritdoc cref="EventHandlersRequiredStaticClassName" path="descendant::value"/>.</item>
            /// <item>Can be static.</item>
            /// <item>Can have members, or not.</item>
            /// <item>Should be in a namespace specifc to your application.</item>
            /// </list>
            /// To use the custom event handlers in Razor markup, be sure to import the namespace containing the event handler attibuted-class
            /// (and of course set a reference to the project or package containing the attributed-class).
            /// <para>Source: <inheritdoc cref="CustomEventExample_MSDocsLink" path="descendant::link"/></para>
            /// </summary>
            public static readonly object EventHandlersClassRequirements;

            /// <summary>
            /// After importing the Microsoft.AspNetCore.Components namespace and creating a class with the required name (<see cref="EventHandlersRequiredStaticClassName"/>),
            /// add an attribute to the class like:
            /// <code>
            /// [EventHandler("ontransitionend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
            /// </code>
            /// This registers the "ontransitionend" event as being available on HTML DOM elements.
            /// Use the event from Razor markup by:
            /// <code>
            /// &lt;div @ontransitionend=this.OnTransitionEnd_ForDetails /&gt;
            /// </code>
            /// Where OnTransitionEnd_ForDetails() is a method available to the component.
            /// </summary>
            public static readonly object HowToUseCustomEventHandler;
        }
    }
}