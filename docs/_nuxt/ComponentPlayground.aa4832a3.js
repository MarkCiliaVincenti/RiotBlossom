import{b,u as m,I as a,a as u,J as S,o as $,i as I,j as P,s as x,v as w,k as C,x as _,ah as z,r as D,W as r}from"./entry.018413b1.js";import{u as E}from"./asyncData.0e2eae73.js";import W from"./ComponentPlaygroundData.9e6708d1.js";import"./TabsHeader.db1f23fb.js";import"./ComponentPlaygroundProps.b78db843.js";import"./ProseH4.16de22c8.js";import"./ProseCodeInline.51722765.js";import"./Badge.efbb1fe3.js";import"./ContentSlot.9f3056d5.js";import"./ProseP.7c0d9983.js";import"./index.c1a739d4.js";import"./ComponentPlaygroundSlots.vue.af3ae09f.js";import"./ComponentPlaygroundTokens.vue.3c85f2ef.js";async function j(o){b();const e=m(o);{const{data:n}=await E(`nuxt-component-meta${e?`-${e}`:""}`,()=>$fetch(`/api/component-meta${e?`/${e}`:""}`));return a(()=>n.value)}}const k=o=>(x("data-v-7d261f72"),o=o(),w(),o),A=k(()=>C("div",{class:"ellipsis-item"},null,-1)),B=[A],N=u({__name:"Ellipsis",props:{width:{type:String,default:"10rem"},height:{type:String,default:"10rem"},zIndex:{type:String,default:"10"},top:{type:String,default:"0"},left:{type:String,default:"auto"},right:{type:String,default:"auto"},blur:{type:String,default:"50px"},colors:{type:Array,default:()=>["rgba(0, 71, 225, 0.22)","rgba(26, 214, 255, 0.22)","rgba(0, 220, 130, 0.22)"]}},setup(o){const e=o,n=a(()=>((t=e)=>t.top)()),s=a(()=>((t=e)=>t.left)()),c=a(()=>((t=e)=>t.right)()),i=a(()=>((t=e)=>t.zIndex)()),f=a(()=>((t=e)=>t.width)()),g=a(()=>((t=e)=>t.height)()),h=a(()=>((t=e)=>`blur(${t.blur})`)()),y=a(()=>((t=e)=>{var l,p,d;return`linear-gradient(97.62deg, ${(l=t==null?void 0:t.colors)==null?void 0:l[0]} 2.27%, ${(p=t==null?void 0:t.colors)==null?void 0:p[1]} 50.88%, ${(d=t==null?void 0:t.colors)==null?void 0:d[2]} 98.48%)`})()),{$pinceau:v}=S(e,void 0,{_6HG_top:n,_31J_insetInlineStart:s,_Cy1_insetInlineEnd:c,_RFz_zIndex:i,_U3d_maxWidth:f,_Rmg_height:g,_MhW_filter:h,_LPh_background:y});return(t,l)=>($(),I("div",{class:P(["ellipsis",[m(v)]])},B,2))}});const R=_(N,[["__scopeId","data-v-7d261f72"]]),V=u({props:{component:{type:String,required:!0},props:{type:Object,required:!1,default:()=>({})}},async setup(o){const e=a(()=>z(o.component)),n=D({...o.props}),s=await j(o.component);return{as:e,formProps:n,componentData:s}},render(o){const e=Object.entries(this.$slots).reduce((n,[s,c])=>{if(s.startsWith("component-")){const i=s.replace("component-","");n[i]=c}return n},{});return r("div",{class:"component-playground"},[r("div",{class:"component-playground-wrapper"},[r(R,{class:"component-playground-ellipsis",blur:"5vw",height:"100%",width:"100%"}),r(o.as,{...o.formProps,class:"component-playground-component"},{...e})]),r(W,{modelValue:o.formProps,componentData:o.componentData,"onUpdate:modelValue":n=>o.formProps=n})])}});const Y=_(V,[["__scopeId","data-v-9ca9b996"]]);export{Y as default};
