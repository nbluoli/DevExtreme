*Note that the **Diagram** widget is in the community technology preview (CTP) development stage.*

This demo shows the **Diagram** widget's capability to load an external tree structure from a linear array.

The widget binds to a data object specified by the [dataSource](/Documentation/ApiReference/UI_Widgets/dxDiagram/Configuration/nodes/#dataSource) option. You should specify the [keyExpr](/Documentation/ApiReference/UI_Widgets/dxDiagram/Configuration/nodes/#keyExpr) and [parentKeyExpr](/Documentation/ApiReference/UI_Widgets/dxDiagram/Configuration/nodes/#parentKeyExpr) options because of the data's linear structure. The **Diagram** uses information from the key fields to transform linear data into a tree.