define("UsrInputNumberMiniPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"alignItems": "stretch"
				}
			},
			{
				"operation": "insert",
				"name": "VisitsNumberInput",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.NumberInput",
					"label": "$Resources.Strings.PageParameters_UsrIntegerParameter1_skrwof1",
					"labelPosition": "above",
					"control": "$PageParameters_UsrIntegerParameter1_skrwof1"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"PageParameters_UsrIntegerParameter1_skrwof1": {
						"modelConfig": {
							"path": "PageParameters.UsrVisitsNumberParameter"
						},
						"validators": {
							"MySuperValidator": {
								"type": "usr.MinMaxValidator",
								"params": {
									"minValue": 1,
                                    "maxValue": 10,
									"message": "#ResourceString(ValueIsOutOfRange110)#"
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{
			/* The validator type must contain a vendor prefix.
			Format the validator type in PascalCase. */
			"usr.MinMaxValidator": {
				validator: function (config) {
					return function (control) {
						let value = control.value;
						let minValue = config.minValue;
						let maxValue = config.maxValue;
						let valueIsCorrect = (value >= minValue) && (value <= maxValue);
						var result;
						if (valueIsCorrect) {
							result = null;
						} else {
							result = {
								"usr.MinMaxValidator": { 
									message: config.message
								}
							};
						}
						return result;
					};
				},
				params: [
					{
						name: "minValue"
					},
					{
						name: "maxValue"
					},
					{
						name: "message"
					}
				],
				async: false
			}

        }/**SCHEMA_VALIDATORS*/
	};
});