#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface BrightnessControl : NSObject

@end

extern "C" void setBrightness(float value);
